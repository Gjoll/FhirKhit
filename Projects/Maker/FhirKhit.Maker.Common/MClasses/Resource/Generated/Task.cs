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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Task'
    /// </summary>
    // 0. Task
    public class Task : FhirKhit.Maker.Common.Resource.ResourceBase                                                                         // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Task_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                            // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 29. Task.restriction
            public class Type_Restriction : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Restriction_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 30. Task.restriction.repetitions
                    public ElementDefinitionInfo Repetitions;                                                                               // MakerGen.cs:236
                    // 31. Task.restriction.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:236
                    // 32. Task.restriction.recipient
                    public ElementDefinitionInfo Recipient;                                                                                 // MakerGen.cs:236
                    public Type_Restriction_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 30. Task.restriction.repetitions
                            this.Repetitions = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Repetitions",                                                                                       // MakerGen.cs:255
                                Path= "Task.restriction.repetitions",                                                                       // MakerGen.cs:256
                                Id = "Task.restriction.repetitions",                                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 31. Task.restriction.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Period",                                                                                            // MakerGen.cs:255
                                Path= "Task.restriction.period",                                                                            // MakerGen.cs:256
                                Id = "Task.restriction.period",                                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 32. Task.restriction.recipient
                            this.Recipient = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Recipient",                                                                                         // MakerGen.cs:255
                                Path= "Task.restriction.recipient",                                                                         // MakerGen.cs:256
                                Id = "Task.restriction.recipient",                                                                          // MakerGen.cs:257
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
                                            "http://hl7.org/fhir/StructureDefinition/Group",                                                // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Repetitions.Write(sDef);                                                                                            // MakerGen.cs:240
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Recipient.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Restriction_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Restriction()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Restriction_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 33. Task.input
            public class Type_Input : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Input_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 34. Task.input.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 35. Task.input.value[x]
                    public ElementDefinitionInfo Value;                                                                                     // MakerGen.cs:236
                    public Type_Input_Elements()                                                                                            // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 34. Task.input.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "Task.input.type",                                                                                    // MakerGen.cs:256
                                Id = "Task.input.type",                                                                                     // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
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
                            // 35. Task.input.value[x]
                            this.Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Value",                                                                                             // MakerGen.cs:255
                                Path= "Task.input.value[x]",                                                                                // MakerGen.cs:256
                                Id = "Task.input.value[x]",                                                                                 // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Base64Binary                                                        // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Instant                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Oid                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Url                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Uuid                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Age                                                                   // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Annotation                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.ContactPoint                                                          // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Count                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Distance                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.HumanName                                                             // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.SampledData                                                           // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Signature                                                             // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Timing                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.ContactDetail                                                         // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Contributor                                                           // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.DataRequirement                                                       // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Expression                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.ParameterDefinition                                                   // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                       // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.TriggerDefinition                                                     // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.UsageContext                                                          // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Dosage                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Value.Write(sDef);                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Input_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Input()                                                                                                         // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Input_Elements();                                                                              // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 36. Task.output
            public class Type_Output : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Output_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 37. Task.output.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 38. Task.output.value[x]
                    public ElementDefinitionInfo Value;                                                                                     // MakerGen.cs:236
                    public Type_Output_Elements()                                                                                           // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 37. Task.output.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "Task.output.type",                                                                                   // MakerGen.cs:256
                                Id = "Task.output.type",                                                                                    // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
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
                            // 38. Task.output.value[x]
                            this.Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Value",                                                                                             // MakerGen.cs:255
                                Path= "Task.output.value[x]",                                                                               // MakerGen.cs:256
                                Id = "Task.output.value[x]",                                                                                // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Base64Binary                                                        // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Instant                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Oid                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Url                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.Uuid                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Age                                                                   // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Annotation                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.ContactPoint                                                          // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Count                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Distance                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.HumanName                                                             // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.SampledData                                                           // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Signature                                                             // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Timing                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.ContactDetail                                                         // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Contributor                                                           // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.DataRequirement                                                       // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Expression                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.ParameterDefinition                                                   // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                       // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.TriggerDefinition                                                     // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.UsageContext                                                          // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Dosage                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Value.Write(sDef);                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Output_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Output()                                                                                                        // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Output_Elements();                                                                             // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. Task.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. Task.instantiatesCanonical
            public ElementDefinitionInfo InstantiatesCanonical;                                                                             // MakerGen.cs:236
            // 3. Task.instantiatesUri
            public ElementDefinitionInfo InstantiatesUri;                                                                                   // MakerGen.cs:236
            // 4. Task.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:236
            // 5. Task.groupIdentifier
            public ElementDefinitionInfo GroupIdentifier;                                                                                   // MakerGen.cs:236
            // 6. Task.partOf
            public ElementDefinitionInfo PartOf;                                                                                            // MakerGen.cs:236
            // 7. Task.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 8. Task.statusReason
            public ElementDefinitionInfo StatusReason;                                                                                      // MakerGen.cs:236
            // 9. Task.businessStatus
            public ElementDefinitionInfo BusinessStatus;                                                                                    // MakerGen.cs:236
            // 10. Task.intent
            public ElementDefinitionInfo Intent;                                                                                            // MakerGen.cs:236
            // 11. Task.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:236
            // 12. Task.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 13. Task.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:236
            // 14. Task.focus
            public ElementDefinitionInfo Focus;                                                                                             // MakerGen.cs:236
            // 15. Task.for
            public ElementDefinitionInfo For;                                                                                               // MakerGen.cs:236
            // 16. Task.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 17. Task.executionPeriod
            public ElementDefinitionInfo ExecutionPeriod;                                                                                   // MakerGen.cs:236
            // 18. Task.authoredOn
            public ElementDefinitionInfo AuthoredOn;                                                                                        // MakerGen.cs:236
            // 19. Task.lastModified
            public ElementDefinitionInfo LastModified;                                                                                      // MakerGen.cs:236
            // 20. Task.requester
            public ElementDefinitionInfo Requester;                                                                                         // MakerGen.cs:236
            // 21. Task.performerType
            public ElementDefinitionInfo PerformerType;                                                                                     // MakerGen.cs:236
            // 22. Task.owner
            public ElementDefinitionInfo Owner;                                                                                             // MakerGen.cs:236
            // 23. Task.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:236
            // 24. Task.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:236
            // 25. Task.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:236
            // 26. Task.insurance
            public ElementDefinitionInfo Insurance;                                                                                         // MakerGen.cs:236
            // 27. Task.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:236
            // 28. Task.relevantHistory
            public ElementDefinitionInfo RelevantHistory;                                                                                   // MakerGen.cs:236
            public Task_Elements()                                                                                                          // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Task.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "Task.identifier",                                                                                            // MakerGen.cs:256
                        Id = "Task.identifier",                                                                                             // MakerGen.cs:257
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
                    // 2. Task.instantiatesCanonical
                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "InstantiatesCanonical",                                                                                     // MakerGen.cs:255
                        Path= "Task.instantiatesCanonical",                                                                                 // MakerGen.cs:256
                        Id = "Task.instantiatesCanonical",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                                TargetProfile = new String[]                                                                                // MakerGen.cs:302
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition"                                            // MakerGen.cs:302
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. Task.instantiatesUri
                    this.InstantiatesUri = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "InstantiatesUri",                                                                                           // MakerGen.cs:255
                        Path= "Task.instantiatesUri",                                                                                       // MakerGen.cs:256
                        Id = "Task.instantiatesUri",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. Task.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:255
                        Path= "Task.basedOn",                                                                                               // MakerGen.cs:256
                        Id = "Task.basedOn",                                                                                                // MakerGen.cs:257
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
                    // 5. Task.groupIdentifier
                    this.GroupIdentifier = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "GroupIdentifier",                                                                                           // MakerGen.cs:255
                        Path= "Task.groupIdentifier",                                                                                       // MakerGen.cs:256
                        Id = "Task.groupIdentifier",                                                                                        // MakerGen.cs:257
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
                    // 6. Task.partOf
                    this.PartOf = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PartOf",                                                                                                    // MakerGen.cs:255
                        Path= "Task.partOf",                                                                                                // MakerGen.cs:256
                        Id = "Task.partOf",                                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Task"                                                          // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. Task.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "Task.status",                                                                                                // MakerGen.cs:256
                        Id = "Task.status",                                                                                                 // MakerGen.cs:257
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
                    // 8. Task.statusReason
                    this.StatusReason = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "StatusReason",                                                                                              // MakerGen.cs:255
                        Path= "Task.statusReason",                                                                                          // MakerGen.cs:256
                        Id = "Task.statusReason",                                                                                           // MakerGen.cs:257
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
                    // 9. Task.businessStatus
                    this.BusinessStatus = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BusinessStatus",                                                                                            // MakerGen.cs:255
                        Path= "Task.businessStatus",                                                                                        // MakerGen.cs:256
                        Id = "Task.businessStatus",                                                                                         // MakerGen.cs:257
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
                    // 10. Task.intent
                    this.Intent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Intent",                                                                                                    // MakerGen.cs:255
                        Path= "Task.intent",                                                                                                // MakerGen.cs:256
                        Id = "Task.intent",                                                                                                 // MakerGen.cs:257
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
                    // 11. Task.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Priority",                                                                                                  // MakerGen.cs:255
                        Path= "Task.priority",                                                                                              // MakerGen.cs:256
                        Id = "Task.priority",                                                                                               // MakerGen.cs:257
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
                    // 12. Task.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "Task.code",                                                                                                  // MakerGen.cs:256
                        Id = "Task.code",                                                                                                   // MakerGen.cs:257
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
                    // 13. Task.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Description",                                                                                               // MakerGen.cs:255
                        Path= "Task.description",                                                                                           // MakerGen.cs:256
                        Id = "Task.description",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 14. Task.focus
                    this.Focus = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Focus",                                                                                                     // MakerGen.cs:255
                        Path= "Task.focus",                                                                                                 // MakerGen.cs:256
                        Id = "Task.focus",                                                                                                  // MakerGen.cs:257
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
                    // 15. Task.for
                    this.For = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "For",                                                                                                       // MakerGen.cs:255
                        Path= "Task.for",                                                                                                   // MakerGen.cs:256
                        Id = "Task.for",                                                                                                    // MakerGen.cs:257
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
                    // 16. Task.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "Task.encounter",                                                                                             // MakerGen.cs:256
                        Id = "Task.encounter",                                                                                              // MakerGen.cs:257
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
                    // 17. Task.executionPeriod
                    this.ExecutionPeriod = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ExecutionPeriod",                                                                                           // MakerGen.cs:255
                        Path= "Task.executionPeriod",                                                                                       // MakerGen.cs:256
                        Id = "Task.executionPeriod",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 18. Task.authoredOn
                    this.AuthoredOn = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AuthoredOn",                                                                                                // MakerGen.cs:255
                        Path= "Task.authoredOn",                                                                                            // MakerGen.cs:256
                        Id = "Task.authoredOn",                                                                                             // MakerGen.cs:257
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
                    // 19. Task.lastModified
                    this.LastModified = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "LastModified",                                                                                              // MakerGen.cs:255
                        Path= "Task.lastModified",                                                                                          // MakerGen.cs:256
                        Id = "Task.lastModified",                                                                                           // MakerGen.cs:257
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
                    // 20. Task.requester
                    this.Requester = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Requester",                                                                                                 // MakerGen.cs:255
                        Path= "Task.requester",                                                                                             // MakerGen.cs:256
                        Id = "Task.requester",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 21. Task.performerType
                    this.PerformerType = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PerformerType",                                                                                             // MakerGen.cs:255
                        Path= "Task.performerType",                                                                                         // MakerGen.cs:256
                        Id = "Task.performerType",                                                                                          // MakerGen.cs:257
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
                    // 22. Task.owner
                    this.Owner = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Owner",                                                                                                     // MakerGen.cs:255
                        Path= "Task.owner",                                                                                                 // MakerGen.cs:256
                        Id = "Task.owner",                                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                            // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 23. Task.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Location",                                                                                                  // MakerGen.cs:255
                        Path= "Task.location",                                                                                              // MakerGen.cs:256
                        Id = "Task.location",                                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 24. Task.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:255
                        Path= "Task.reasonCode",                                                                                            // MakerGen.cs:256
                        Id = "Task.reasonCode",                                                                                             // MakerGen.cs:257
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
                    // 25. Task.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:255
                        Path= "Task.reasonReference",                                                                                       // MakerGen.cs:256
                        Id = "Task.reasonReference",                                                                                        // MakerGen.cs:257
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
                    // 26. Task.insurance
                    this.Insurance = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Insurance",                                                                                                 // MakerGen.cs:255
                        Path= "Task.insurance",                                                                                             // MakerGen.cs:256
                        Id = "Task.insurance",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Coverage",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ClaimResponse"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 27. Task.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Note",                                                                                                      // MakerGen.cs:255
                        Path= "Task.note",                                                                                                  // MakerGen.cs:256
                        Id = "Task.note",                                                                                                   // MakerGen.cs:257
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
                {                                                                                                                           // MakerGen.cs:251
                    // 28. Task.relevantHistory
                    this.RelevantHistory = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "RelevantHistory",                                                                                           // MakerGen.cs:255
                        Path= "Task.relevantHistory",                                                                                       // MakerGen.cs:256
                        Id = "Task.relevantHistory",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Provenance"                                                    // MakerGen.cs:348
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
                InstantiatesCanonical.Write(sDef);                                                                                          // MakerGen.cs:240
                InstantiatesUri.Write(sDef);                                                                                                // MakerGen.cs:240
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:240
                GroupIdentifier.Write(sDef);                                                                                                // MakerGen.cs:240
                PartOf.Write(sDef);                                                                                                         // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                StatusReason.Write(sDef);                                                                                                   // MakerGen.cs:240
                BusinessStatus.Write(sDef);                                                                                                 // MakerGen.cs:240
                Intent.Write(sDef);                                                                                                         // MakerGen.cs:240
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Description.Write(sDef);                                                                                                    // MakerGen.cs:240
                Focus.Write(sDef);                                                                                                          // MakerGen.cs:240
                For.Write(sDef);                                                                                                            // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                ExecutionPeriod.Write(sDef);                                                                                                // MakerGen.cs:240
                AuthoredOn.Write(sDef);                                                                                                     // MakerGen.cs:240
                LastModified.Write(sDef);                                                                                                   // MakerGen.cs:240
                Requester.Write(sDef);                                                                                                      // MakerGen.cs:240
                PerformerType.Write(sDef);                                                                                                  // MakerGen.cs:240
                Owner.Write(sDef);                                                                                                          // MakerGen.cs:240
                Location.Write(sDef);                                                                                                       // MakerGen.cs:240
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:240
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:240
                Insurance.Write(sDef);                                                                                                      // MakerGen.cs:240
                Note.Write(sDef);                                                                                                           // MakerGen.cs:240
                RelevantHistory.Write(sDef);                                                                                                // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Task_Elements Elements { get; }                                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Task()                                                                                                                       // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Task_Elements();                                                                                            // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
