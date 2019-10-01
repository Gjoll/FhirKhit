using System;                                                                                                                               // MakerGen.cs:413
using System.Diagnostics;                                                                                                                   // MakerGen.cs:414
using System.IO;                                                                                                                            // MakerGen.cs:415
using System.Linq;                                                                                                                          // MakerGen.cs:416
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:417
                                                                                                                                            // MakerGen.cs:418
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:419
{                                                                                                                                           // MakerGen.cs:420
    #region Json                                                                                                                            // MakerGen.cs:421
    #if NEVER                                                                                                                               // MakerGen.cs:422
    {
      "resourceType": "StructureDefinition",
      "id": "Task",
      "url": "http://hl7.org/fhir/StructureDefinition/Task",
      "version": "4.0.0",
      "name": "Task",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A task to be performed.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Task",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Task",
            "path": "Task",
            "short": "A task to be performed",
            "definition": "A task to be performed.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Task.identifier",
            "path": "Task.identifier",
            "short": "Task Instance Identifier",
            "definition": "The business identifier for this task.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Task.instantiatesCanonical",
            "path": "Task.instantiatesCanonical",
            "short": "Formal definition of task",
            "definition": "The URL pointing to a *FHIR*-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this Task.",
            "requirements": "Enables a formal definition of how he task is to be performed, enabling automation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Task.instantiatesUri",
            "path": "Task.instantiatesUri",
            "short": "Formal definition of task",
            "definition": "The URL pointing to an *externally* maintained  protocol, guideline, orderset or other definition that is adhered to in whole or in part by this Task.",
            "requirements": "Enables a formal definition of how he task is to be performed (e.g. using BPMN, BPEL, XPDL or other formal notation to be associated with a task), enabling automation.",
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
            "id": "Task.basedOn",
            "path": "Task.basedOn",
            "short": "Request fulfilled by this task",
            "definition": "BasedOn refers to a higher-level authorization that triggered the creation of the task.  It references a \"request\" resource such as a ServiceRequest, MedicationRequest, ServiceRequest, CarePlan, etc. which is distinct from the \"request\" resource the task is seeking to fulfill.  This latter resource is referenced by FocusOn.  For example, based on a ServiceRequest (= BasedOn), a task is created to fulfill a procedureRequest ( = FocusOn ) to collect a specimen from a patient.",
            "min": 0,
            "max": "*",
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
            "id": "Task.groupIdentifier",
            "path": "Task.groupIdentifier",
            "short": "Requisition or grouper id",
            "definition": "An identifier that links together multiple tasks and other requests that were created in the same context.",
            "requirements": "Billing and/or reporting can be linked to whether multiple requests were created as a single unit.",
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
            "id": "Task.partOf",
            "path": "Task.partOf",
            "short": "Composite task",
            "definition": "Task that this particular task is part of.",
            "comment": "This should usually be 0..1.",
            "requirements": "Allows tasks to be broken down into sub-steps (and this division can occur independent of the original task).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Task"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Task.status",
            "path": "Task.status",
            "short": "draft | requested | received | accepted | +",
            "definition": "The current status of the task.",
            "requirements": "These states enable coordination of task status with off-the-shelf workflow solutions that support automation of tasks.",
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
                  "valueString": "TaskStatus"
                }
              ],
              "strength": "required",
              "description": "The current status of the task.",
              "valueSet": "http://hl7.org/fhir/ValueSet/task-status|4.0.0"
            }
          },
          {
            "id": "Task.statusReason",
            "path": "Task.statusReason",
            "short": "Reason for current status",
            "definition": "An explanation as to why this task is held, failed, was refused, etc.",
            "comment": "This applies to the current status.  Look at the history of the task to see reasons for past statuses.",
            "min": 0,
            "max": "1",
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
                  "valueString": "TaskStatusReason"
                }
              ],
              "strength": "example",
              "description": "Codes to identify the reason for current status.  These will typically be specific to a particular workflow."
            }
          },
          {
            "id": "Task.businessStatus",
            "path": "Task.businessStatus",
            "short": "E.g. \"Specimen collected\", \"IV prepped\"",
            "definition": "Contains business-specific nuances of the business state.",
            "requirements": "There's often a need to track substates of a task - this is often variable by specific workflow implementation.",
            "min": 0,
            "max": "1",
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
                  "valueString": "TaskBusinessStatus"
                }
              ],
              "strength": "example",
              "description": "The domain-specific business-contextual sub-state of the task.  For example: \"Blood drawn\", \"IV inserted\", \"Awaiting physician signature\", etc."
            }
          },
          {
            "id": "Task.intent",
            "path": "Task.intent",
            "short": "unknown | proposal | plan | order | original-order | reflex-order | filler-order | instance-order | option",
            "definition": "Indicates the \"level\" of actionability associated with the Task, i.e. i+R[9]Cs this a proposed task, a planned task, an actionable task, etc.",
            "comment": "This element is immutable.  Proposed tasks, planned tasks, etc. must be distinct instances.\n\nIn most cases, Tasks will have an intent of \"order\".",
            "min": 1,
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
                  "valueString": "TaskIntent"
                }
              ],
              "strength": "required",
              "description": "Distinguishes whether the task is a proposal, plan or full order.",
              "valueSet": "http://hl7.org/fhir/ValueSet/task-intent|4.0.0"
            }
          },
          {
            "id": "Task.priority",
            "path": "Task.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly the Task should be addressed with respect to other requests.",
            "requirements": "Used to identify the service level expected while performing a task.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If missing, this task should be performed with normal priority",
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "TaskPriority"
                }
              ],
              "strength": "required",
              "description": "The task's priority.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "Task.code",
            "path": "Task.code",
            "short": "Task Type",
            "definition": "A name or code (or both) briefly describing what the task involves.",
            "comment": "The title (eg \"My Tasks\", \"Outstanding Tasks for Patient X\") should go into the code.",
            "min": 0,
            "max": "1",
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
                  "valueString": "TaskCode"
                }
              ],
              "strength": "example",
              "description": "Codes to identify what the task involves.  These will typically be specific to a particular workflow.",
              "valueSet": "http://hl7.org/fhir/ValueSet/task-code"
            }
          },
          {
            "id": "Task.description",
            "path": "Task.description",
            "short": "Human-readable explanation of task",
            "definition": "A free-text description of what is to be performed.",
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
            "id": "Task.focus",
            "path": "Task.focus",
            "short": "What task is acting on",
            "definition": "The request being actioned or the resource being manipulated by this task.",
            "comment": "If multiple resources need to be manipulated, use sub-tasks.  (This ensures that status can be tracked independently for each referenced resource.).",
            "requirements": "Used to identify the thing to be done.",
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
            "id": "Task.for",
            "path": "Task.for",
            "short": "Beneficiary of the Task",
            "definition": "The entity who benefits from the performance of the service specified in the task (e.g., the patient).",
            "requirements": "Used to track tasks outstanding for a beneficiary.  Do not use to track the task owner or creator (see owner and creator respectively).  This can also affect access control.",
            "alias": [
              "Patient"
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
            "id": "Task.encounter",
            "path": "Task.encounter",
            "short": "Healthcare event during which this task originated",
            "definition": "The healthcare event  (e.g. a patient and healthcare provider interaction) during which this task was created.",
            "requirements": "For some tasks it may be important to know the link between the encounter the task originated within.",
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
            "id": "Task.executionPeriod",
            "path": "Task.executionPeriod",
            "short": "Start and end time of execution",
            "definition": "Identifies the time action was first taken against the task (start) and/or the time final action was taken against the task prior to marking it as completed (end).",
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
            "id": "Task.authoredOn",
            "path": "Task.authoredOn",
            "short": "Task Creation Date",
            "definition": "The date and time this task was created.",
            "requirements": "Most often used along with lastUpdated to track duration of task to supporting monitoring and management.",
            "alias": [
              "Created Date"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "condition": [
              "inv-1"
            ]
          },
          {
            "id": "Task.lastModified",
            "path": "Task.lastModified",
            "short": "Task Last Modified Date",
            "definition": "The date and time of last modification to this task.",
            "requirements": "Used along with history to track task activity and time in a particular task state.  This enables monitoring and management.",
            "alias": [
              "Update Date"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "condition": [
              "inv-1"
            ],
            "isSummary": true
          },
          {
            "id": "Task.requester",
            "path": "Task.requester",
            "short": "Who is asking for task to be done",
            "definition": "The creator of the task.",
            "requirements": "Identifies who created this task.  May be used by access control mechanisms (e.g., to ensure that only the creator can cancel a task).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
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
            "id": "Task.performerType",
            "path": "Task.performerType",
            "short": "Requested performer",
            "definition": "The kind of participant that should perform the task.",
            "requirements": "Use to distinguish tasks on different activity queues.",
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
                  "valueString": "TaskPerformerType"
                }
              ],
              "strength": "preferred",
              "description": "The type(s) of task performers allowed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/performer-role"
            }
          },
          {
            "id": "Task.owner",
            "path": "Task.owner",
            "short": "Responsible individual",
            "definition": "Individual organization or Device currently responsible for task execution.",
            "comment": "Tasks may be created with an owner not yet identified.",
            "requirements": "Identifies who is expected to perform this task.",
            "alias": [
              "Performer",
              "Executer"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Task.location",
            "path": "Task.location",
            "short": "Where task occurs",
            "definition": "Principal physical location where the this task is performed.",
            "requirements": "Ties the event to where the records are likely kept and provides context around the event occurrence (e.g. if it occurred inside or outside a dedicated healthcare setting).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Task.reasonCode",
            "path": "Task.reasonCode",
            "short": "Why task is needed",
            "definition": "A description or code indicating why this task needs to be performed.",
            "comment": "This should only be included if there is no focus or if it differs from the reason indicated on the focus.",
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
                  "valueString": "TaskReason"
                }
              ],
              "strength": "example",
              "description": "Indicates why the task is needed.  E.g. Suspended because patient admitted to hospital."
            }
          },
          {
            "id": "Task.reasonReference",
            "path": "Task.reasonReference",
            "short": "Why task is needed",
            "definition": "A resource reference indicating why this task needs to be performed.",
            "comment": "Tasks might be justified based on an Observation, a Condition, a past or planned procedure, etc.   This should only be included if there is no focus or if it differs from the reason indicated on the focus.    Use the CodeableConcept text element in `Task.reasonCode` if the data is free (uncoded) text.",
            "min": 0,
            "max": "1",
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
            "id": "Task.insurance",
            "path": "Task.insurance",
            "short": "Associated insurance coverage",
            "definition": "Insurance plans, coverage extensions, pre-authorizations and/or pre-determinations that may be relevant to the Task.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Coverage",
                  "http://hl7.org/fhir/StructureDefinition/ClaimResponse"
                ]
              }
            ]
          },
          {
            "id": "Task.note",
            "path": "Task.note",
            "short": "Comments made about the task",
            "definition": "Free-text information captured about the task as it progresses.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "Task.relevantHistory",
            "path": "Task.relevantHistory",
            "short": "Key events in history of the Task",
            "definition": "Links to Provenance records for past versions of this Task that identify key state transitions or updates that are likely to be relevant to a user looking at the current version of the task.",
            "comment": "This element does not point to the Provenance associated with the *current* version of the resource - as it would be created after this version existed.  The Provenance for the current version can be retrieved with a _revinclude.",
            "alias": [
              "Status History"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Provenance"
                ]
              }
            ]
          },
          {
            "id": "Task.restriction",
            "path": "Task.restriction",
            "short": "Constraints on fulfillment tasks",
            "definition": "If the Task.focus is a request resource and the task is seeking fulfillment (i.e. is asking for the request to be actioned), this element identifies any limitations on what parts of the referenced request should be actioned.",
            "requirements": "Sometimes when fulfillment is sought, you don't want full fulfillment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Task.restriction.repetitions",
            "path": "Task.restriction.repetitions",
            "short": "How many times to repeat",
            "definition": "Indicates the number of times the requested action should occur.",
            "requirements": "E.g. order that requests monthly lab tests, fulfillment is sought for 1.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "Task.restriction.period",
            "path": "Task.restriction.period",
            "short": "When fulfillment sought",
            "definition": "Over what time-period is fulfillment sought.",
            "comment": "Note that period.high is the due date representing the time by which the task should be completed.",
            "requirements": "E.g. order that authorizes 1 year's services.  Fulfillment is sought for next 3 months.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Task.restriction.recipient",
            "path": "Task.restriction.recipient",
            "short": "For whom is fulfillment sought?",
            "definition": "For requests that are targeted to more than on potential recipient/target, for whom is fulfillment sought?",
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
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Task.input",
            "path": "Task.input",
            "short": "Information used to perform task",
            "definition": "Additional information that may be needed in the execution of the task.",
            "requirements": "Resources and data used to perform the task.  This data is used in the business logic of task execution, and is stored separately because it varies between workflows.",
            "alias": [
              "Supporting Information"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Task.input.type",
            "path": "Task.input.type",
            "short": "Label for the input",
            "definition": "A code or description indicating how the input is intended to be used as part of the task execution.",
            "comment": "If referencing a BPMN workflow or Protocol, the \"system\" is the URL for the workflow definition and the code is the \"name\" of the required input.",
            "requirements": "Inputs are named to enable task automation to bind data and pass it from one task to the next.",
            "alias": [
              "Name"
            ],
            "min": 1,
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
                  "valueString": "TaskInputParameterType"
                }
              ],
              "strength": "example",
              "description": "Codes to identify types of input parameters.  These will typically be specific to a particular workflow.  E.g. \"Comparison source\", \"Applicable consent\", \"Concomitent Medications\", etc."
            }
          },
          {
            "id": "Task.input.value[x]",
            "path": "Task.input.value[x]",
            "short": "Content to use in performing the task",
            "definition": "The value of the input parameter as a basic type.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              },
              {
                "code": "boolean"
              },
              {
                "code": "canonical"
              },
              {
                "code": "code"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "decimal"
              },
              {
                "code": "id"
              },
              {
                "code": "instant"
              },
              {
                "code": "integer"
              },
              {
                "code": "markdown"
              },
              {
                "code": "oid"
              },
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              },
              {
                "code": "time"
              },
              {
                "code": "unsignedInt"
              },
              {
                "code": "uri"
              },
              {
                "code": "url"
              },
              {
                "code": "uuid"
              },
              {
                "code": "Address"
              },
              {
                "code": "Age"
              },
              {
                "code": "Annotation"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Coding"
              },
              {
                "code": "ContactPoint"
              },
              {
                "code": "Count"
              },
              {
                "code": "Distance"
              },
              {
                "code": "Duration"
              },
              {
                "code": "HumanName"
              },
              {
                "code": "Identifier"
              },
              {
                "code": "Money"
              },
              {
                "code": "Period"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "Reference"
              },
              {
                "code": "SampledData"
              },
              {
                "code": "Signature"
              },
              {
                "code": "Timing"
              },
              {
                "code": "ContactDetail"
              },
              {
                "code": "Contributor"
              },
              {
                "code": "DataRequirement"
              },
              {
                "code": "Expression"
              },
              {
                "code": "ParameterDefinition"
              },
              {
                "code": "RelatedArtifact"
              },
              {
                "code": "TriggerDefinition"
              },
              {
                "code": "UsageContext"
              },
              {
                "code": "Dosage"
              }
            ]
          },
          {
            "id": "Task.output",
            "path": "Task.output",
            "short": "Information produced as part of task",
            "definition": "Outputs produced by the Task.",
            "requirements": "Resources and data produced during the execution the task.  This data is generated by the business logic of task execution, and is stored separately because it varies between workflows.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Task.output.type",
            "path": "Task.output.type",
            "short": "Label for output",
            "definition": "The name of the Output parameter.",
            "requirements": "Outputs are named to enable task automation to bind data and pass it from one task to the next.",
            "alias": [
              "Name"
            ],
            "min": 1,
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
                  "valueString": "TaskOutputParameterType"
                }
              ],
              "strength": "example",
              "description": "Codes to identify types of input parameters.  These will typically be specific to a particular workflow.  E.g. \"Identified issues\", \"Preliminary results\", \"Filler order\", \"Final results\", etc."
            }
          },
          {
            "id": "Task.output.value[x]",
            "path": "Task.output.value[x]",
            "short": "Result of output",
            "definition": "The value of the Output parameter as a basic type.",
            "requirements": "Task outputs can take any form.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              },
              {
                "code": "boolean"
              },
              {
                "code": "canonical"
              },
              {
                "code": "code"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "decimal"
              },
              {
                "code": "id"
              },
              {
                "code": "instant"
              },
              {
                "code": "integer"
              },
              {
                "code": "markdown"
              },
              {
                "code": "oid"
              },
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              },
              {
                "code": "time"
              },
              {
                "code": "unsignedInt"
              },
              {
                "code": "uri"
              },
              {
                "code": "url"
              },
              {
                "code": "uuid"
              },
              {
                "code": "Address"
              },
              {
                "code": "Age"
              },
              {
                "code": "Annotation"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Coding"
              },
              {
                "code": "ContactPoint"
              },
              {
                "code": "Count"
              },
              {
                "code": "Distance"
              },
              {
                "code": "Duration"
              },
              {
                "code": "HumanName"
              },
              {
                "code": "Identifier"
              },
              {
                "code": "Money"
              },
              {
                "code": "Period"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "Reference"
              },
              {
                "code": "SampledData"
              },
              {
                "code": "Signature"
              },
              {
                "code": "Timing"
              },
              {
                "code": "ContactDetail"
              },
              {
                "code": "Contributor"
              },
              {
                "code": "DataRequirement"
              },
              {
                "code": "Expression"
              },
              {
                "code": "ParameterDefinition"
              },
              {
                "code": "RelatedArtifact"
              },
              {
                "code": "TriggerDefinition"
              },
              {
                "code": "UsageContext"
              },
              {
                "code": "Dosage"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:425
    /// <summary>
    /// Fhir resource 'Task'
    /// </summary>
    // 0. Task
    public class Task : FhirKhit.Maker.Common.Resource.ResourceBase                                                                         // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 29. Task.restriction
        public class Type_Restriction : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 30. Task.restriction.repetitions
            public MakerElementInstance Element_Repetitions;                                                                                // MakerGen.cs:232
            // 31. Task.restriction.period
            public MakerElementInstance Element_Period;                                                                                     // MakerGen.cs:232
            // 32. Task.restriction.recipient
            public MakerElementInstance Element_Recipient;                                                                                  // MakerGen.cs:232
            public Type_Restriction()                                                                                                       // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 30. Task.restriction.repetitions
                    this.Element_Repetitions = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Repetitions",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 31. Task.restriction.period
                    this.Element_Period = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Period",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 32. Task.restriction.recipient
                    this.Element_Recipient = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Recipient",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:335
                            {                                                                                                               // MakerGen.cs:336
                                TargetProfile = new String[]                                                                                // MakerGen.cs:338
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:338
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:338
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:338
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:338
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:338
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:338
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:339
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 33. Task.input
        public class Type_Input : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 34. Task.input.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 35. Task.input.value[x]
            public MakerElementInstance Element_Value;                                                                                      // MakerGen.cs:232
            public Type_Input()                                                                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 34. Task.input.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 35. Task.input.value[x]
                    this.Element_Value = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Value",                                                                                             // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Base64Binary                                                                // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Id                                                                          // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Instant                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Oid                                                                         // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Time                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                                 // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Url                                                                         // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Uuid                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Complex.Address                                                                       // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Age                                                                           // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            },                                                                                                              // MakerGen.cs:308
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            },                                                                                                              // MakerGen.cs:308
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Count                                                                         // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Distance                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Duration                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.HumanName                                                                     // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Money                                                                         // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Ratio                                                                         // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:335
                            {                                                                                                               // MakerGen.cs:336
                            },                                                                                                              // MakerGen.cs:339
                            new FhirKhit.Maker.Common.Complex.SampledData                                                                   // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Signature                                                                     // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Contributor                                                                   // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.DataRequirement                                                               // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Expression                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.ParameterDefinition                                                           // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                               // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.TriggerDefinition                                                             // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Dosage                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 36. Task.output
        public class Type_Output : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 37. Task.output.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 38. Task.output.value[x]
            public MakerElementInstance Element_Value;                                                                                      // MakerGen.cs:232
            public Type_Output()                                                                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 37. Task.output.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 38. Task.output.value[x]
                    this.Element_Value = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Value",                                                                                             // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Base64Binary                                                                // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Id                                                                          // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Instant                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Oid                                                                         // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Time                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                                 // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Url                                                                         // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Primitive.Uuid                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Complex.Address                                                                       // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Age                                                                           // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            },                                                                                                              // MakerGen.cs:308
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            },                                                                                                              // MakerGen.cs:308
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Count                                                                         // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Distance                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Duration                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.HumanName                                                                     // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Money                                                                         // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Ratio                                                                         // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:335
                            {                                                                                                               // MakerGen.cs:336
                            },                                                                                                              // MakerGen.cs:339
                            new FhirKhit.Maker.Common.Complex.SampledData                                                                   // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Signature                                                                     // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Contributor                                                                   // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.DataRequirement                                                               // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Expression                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.ParameterDefinition                                                           // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                               // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.TriggerDefinition                                                             // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            },                                                                                                              // MakerGen.cs:349
                            new FhirKhit.Maker.Common.Complex.Dosage                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 1. Task.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. Task.instantiatesCanonical
        public MakerElementInstance Element_InstantiatesCanonical;                                                                          // MakerGen.cs:232
        // 3. Task.instantiatesUri
        public MakerElementInstance Element_InstantiatesUri;                                                                                // MakerGen.cs:232
        // 4. Task.basedOn
        public MakerElementInstance Element_BasedOn;                                                                                        // MakerGen.cs:232
        // 5. Task.groupIdentifier
        public MakerElementInstance Element_GroupIdentifier;                                                                                // MakerGen.cs:232
        // 6. Task.partOf
        public MakerElementInstance Element_PartOf;                                                                                         // MakerGen.cs:232
        // 7. Task.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 8. Task.statusReason
        public MakerElementInstance Element_StatusReason;                                                                                   // MakerGen.cs:232
        // 9. Task.businessStatus
        public MakerElementInstance Element_BusinessStatus;                                                                                 // MakerGen.cs:232
        // 10. Task.intent
        public MakerElementInstance Element_Intent;                                                                                         // MakerGen.cs:232
        // 11. Task.priority
        public MakerElementInstance Element_Priority;                                                                                       // MakerGen.cs:232
        // 12. Task.code
        public MakerElementInstance Element_Code;                                                                                           // MakerGen.cs:232
        // 13. Task.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 14. Task.focus
        public MakerElementInstance Element_Focus;                                                                                          // MakerGen.cs:232
        // 15. Task.for
        public MakerElementInstance Element_For;                                                                                            // MakerGen.cs:232
        // 16. Task.encounter
        public MakerElementInstance Element_Encounter;                                                                                      // MakerGen.cs:232
        // 17. Task.executionPeriod
        public MakerElementInstance Element_ExecutionPeriod;                                                                                // MakerGen.cs:232
        // 18. Task.authoredOn
        public MakerElementInstance Element_AuthoredOn;                                                                                     // MakerGen.cs:232
        // 19. Task.lastModified
        public MakerElementInstance Element_LastModified;                                                                                   // MakerGen.cs:232
        // 20. Task.requester
        public MakerElementInstance Element_Requester;                                                                                      // MakerGen.cs:232
        // 21. Task.performerType
        public MakerElementInstance Element_PerformerType;                                                                                  // MakerGen.cs:232
        // 22. Task.owner
        public MakerElementInstance Element_Owner;                                                                                          // MakerGen.cs:232
        // 23. Task.location
        public MakerElementInstance Element_Location;                                                                                       // MakerGen.cs:232
        // 24. Task.reasonCode
        public MakerElementInstance Element_ReasonCode;                                                                                     // MakerGen.cs:232
        // 25. Task.reasonReference
        public MakerElementInstance Element_ReasonReference;                                                                                // MakerGen.cs:232
        // 26. Task.insurance
        public MakerElementInstance Element_Insurance;                                                                                      // MakerGen.cs:232
        // 27. Task.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        // 28. Task.relevantHistory
        public MakerElementInstance Element_RelevantHistory;                                                                                // MakerGen.cs:232
        public Task()                                                                                                                       // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. Task.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. Task.instantiatesCanonical
                this.Element_InstantiatesCanonical = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesCanonical",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical                                                                       // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:292
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition"                                                // MakerGen.cs:292
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. Task.instantiatesUri
                this.Element_InstantiatesUri = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesUri",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri                                                                             // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 4. Task.basedOn
                this.Element_BasedOn = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 5. Task.groupIdentifier
                this.Element_GroupIdentifier = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_GroupIdentifier",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 6. Task.partOf
                this.Element_PartOf = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Task"                                                              // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 7. Task.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 8. Task.statusReason
                this.Element_StatusReason = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 9. Task.businessStatus
                this.Element_BusinessStatus = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_BusinessStatus",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 10. Task.intent
                this.Element_Intent = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Intent",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 11. Task.priority
                this.Element_Priority = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Priority",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 12. Task.code
                this.Element_Code = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 13. Task.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 14. Task.focus
                this.Element_Focus = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Focus",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 15. Task.for
                this.Element_For = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_For",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 16. Task.encounter
                this.Element_Encounter = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 17. Task.executionPeriod
                this.Element_ExecutionPeriod = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ExecutionPeriod",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Period                                                                            // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 18. Task.authoredOn
                this.Element_AuthoredOn = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AuthoredOn",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 19. Task.lastModified
                this.Element_LastModified = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LastModified",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 20. Task.requester
                this.Element_Requester = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Requester",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 21. Task.performerType
                this.Element_PerformerType = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PerformerType",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 22. Task.owner
                this.Element_Owner = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Owner",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/CareTeam",                                                         // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                                // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 23. Task.location
                this.Element_Location = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Location",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 24. Task.reasonCode
                this.Element_ReasonCode = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 25. Task.reasonReference
                this.Element_ReasonReference = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 26. Task.insurance
                this.Element_Insurance = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Insurance",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Coverage",                                                         // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/ClaimResponse"                                                     // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 27. Task.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Annotation                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 28. Task.relevantHistory
                this.Element_RelevantHistory = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_RelevantHistory",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Provenance"                                                        // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:430
