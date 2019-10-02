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
    #endregion
    /// <summary>
    /// Fhir resource 'Task'
    /// </summary>
    // 0. Task
    public partial class Resource_Task : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 29. Task.restriction
        public partial class Type_Restriction : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 30. Task.restriction.repetitions
            public ElementDefinitionInfo Element_Repetitions;
            // 31. Task.restriction.period
            public ElementDefinitionInfo Element_Period;
            // 32. Task.restriction.recipient
            public ElementDefinitionInfo Element_Recipient;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Task.restriction",
                    ElementId = "Task.restriction"
                });
                Element_Repetitions.Write(sDef);
                Element_Period.Write(sDef);
                Element_Recipient.Write(sDef);
            }
            
            public Type_Restriction()
            {
                {
                    // 30. Task.restriction.repetitions
                    this.Element_Repetitions = new ElementDefinitionInfo
                    {
                        Name = "Element_Repetitions",
                        Path= "Task.restriction.repetitions",
                        Id = "Task.restriction.repetitions",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            }
                        }
                    };
                }
                {
                    // 31. Task.restriction.period
                    this.Element_Period = new ElementDefinitionInfo
                    {
                        Name = "Element_Period",
                        Path= "Task.restriction.period",
                        Id = "Task.restriction.period",
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
                    // 32. Task.restriction.recipient
                    this.Element_Recipient = new ElementDefinitionInfo
                    {
                        Name = "Element_Recipient",
                        Path= "Task.restriction.recipient",
                        Id = "Task.restriction.recipient",
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
                                    "http://hl7.org/fhir/StructureDefinition/Group",
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 33. Task.input
        public partial class Type_Input : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 34. Task.input.type
            public ElementDefinitionInfo Element_Type;
            // 35. Task.input.value[x]
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Task.input",
                    ElementId = "Task.input"
                });
                Element_Type.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_Input()
            {
                {
                    // 34. Task.input.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Task.input.type",
                        Id = "Task.input.type",
                        Min = 1,
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
                    // 35. Task.input.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "Task.input.value[x]",
                        Id = "Task.input.value[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Date
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Id
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Oid
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Url
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uuid
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Address
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Age
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Annotation
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Count
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Distance
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_HumanName
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Money
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Ratio
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_SampledData
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Signature
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_ContactDetail
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Contributor
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Expression
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_ParameterDefinition
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_TriggerDefinition
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_UsageContext
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Dosage
                            {
                            }
                        }
                    };
                }
            }
        }
        // 36. Task.output
        public partial class Type_Output : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 37. Task.output.type
            public ElementDefinitionInfo Element_Type;
            // 38. Task.output.value[x]
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Task.output",
                    ElementId = "Task.output"
                });
                Element_Type.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_Output()
            {
                {
                    // 37. Task.output.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Task.output.type",
                        Id = "Task.output.type",
                        Min = 1,
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
                    // 38. Task.output.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "Task.output.value[x]",
                        Id = "Task.output.value[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Date
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Id
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Oid
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Url
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uuid
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Address
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Age
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Annotation
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Count
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Distance
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_HumanName
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Money
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Ratio
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_SampledData
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Signature
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_ContactDetail
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Contributor
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Expression
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_ParameterDefinition
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_TriggerDefinition
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_UsageContext
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Dosage
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. Task.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Task.instantiatesCanonical
        public ElementDefinitionInfo Element_InstantiatesCanonical;
        // 3. Task.instantiatesUri
        public ElementDefinitionInfo Element_InstantiatesUri;
        // 4. Task.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 5. Task.groupIdentifier
        public ElementDefinitionInfo Element_GroupIdentifier;
        // 6. Task.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 7. Task.status
        public ElementDefinitionInfo Element_Status;
        // 8. Task.statusReason
        public ElementDefinitionInfo Element_StatusReason;
        // 9. Task.businessStatus
        public ElementDefinitionInfo Element_BusinessStatus;
        // 10. Task.intent
        public ElementDefinitionInfo Element_Intent;
        // 11. Task.priority
        public ElementDefinitionInfo Element_Priority;
        // 12. Task.code
        public ElementDefinitionInfo Element_Code;
        // 13. Task.description
        public ElementDefinitionInfo Element_Description;
        // 14. Task.focus
        public ElementDefinitionInfo Element_Focus;
        // 15. Task.for
        public ElementDefinitionInfo Element_For;
        // 16. Task.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 17. Task.executionPeriod
        public ElementDefinitionInfo Element_ExecutionPeriod;
        // 18. Task.authoredOn
        public ElementDefinitionInfo Element_AuthoredOn;
        // 19. Task.lastModified
        public ElementDefinitionInfo Element_LastModified;
        // 20. Task.requester
        public ElementDefinitionInfo Element_Requester;
        // 21. Task.performerType
        public ElementDefinitionInfo Element_PerformerType;
        // 22. Task.owner
        public ElementDefinitionInfo Element_Owner;
        // 23. Task.location
        public ElementDefinitionInfo Element_Location;
        // 24. Task.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 25. Task.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 26. Task.insurance
        public ElementDefinitionInfo Element_Insurance;
        // 27. Task.note
        public ElementDefinitionInfo Element_Note;
        // 28. Task.relevantHistory
        public ElementDefinitionInfo Element_RelevantHistory;
        // 29. Task.restriction
        public ElementDefinitionInfo Element_Restriction;
        // 33. Task.input
        public ElementDefinitionInfo Element_Input;
        // 36. Task.output
        public ElementDefinitionInfo Element_Output;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Task",
                ElementId = "Task"
            });
            Element_Identifier.Write(sDef);
            Element_InstantiatesCanonical.Write(sDef);
            Element_InstantiatesUri.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_GroupIdentifier.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusReason.Write(sDef);
            Element_BusinessStatus.Write(sDef);
            Element_Intent.Write(sDef);
            Element_Priority.Write(sDef);
            Element_Code.Write(sDef);
            Element_Description.Write(sDef);
            Element_Focus.Write(sDef);
            Element_For.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_ExecutionPeriod.Write(sDef);
            Element_AuthoredOn.Write(sDef);
            Element_LastModified.Write(sDef);
            Element_Requester.Write(sDef);
            Element_PerformerType.Write(sDef);
            Element_Owner.Write(sDef);
            Element_Location.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_Insurance.Write(sDef);
            Element_Note.Write(sDef);
            Element_RelevantHistory.Write(sDef);
            Element_Restriction.Write(sDef);
            Element_Input.Write(sDef);
            Element_Output.Write(sDef);
        }
        
        public Resource_Task()
        {
            {
                // 1. Task.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Task.identifier",
                    Id = "Task.identifier",
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
                // 2. Task.instantiatesCanonical
                this.Element_InstantiatesCanonical = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesCanonical",
                    Path= "Task.instantiatesCanonical",
                    Id = "Task.instantiatesCanonical",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 3. Task.instantiatesUri
                this.Element_InstantiatesUri = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesUri",
                    Path= "Task.instantiatesUri",
                    Id = "Task.instantiatesUri",
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
                // 4. Task.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "Task.basedOn",
                    Id = "Task.basedOn",
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
                // 5. Task.groupIdentifier
                this.Element_GroupIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_GroupIdentifier",
                    Path= "Task.groupIdentifier",
                    Id = "Task.groupIdentifier",
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
                // 6. Task.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "Task.partOf",
                    Id = "Task.partOf",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Task"
                            }
                        }
                    }
                };
            }
            {
                // 7. Task.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Task.status",
                    Id = "Task.status",
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
                // 8. Task.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo
                {
                    Name = "Element_StatusReason",
                    Path= "Task.statusReason",
                    Id = "Task.statusReason",
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
                // 9. Task.businessStatus
                this.Element_BusinessStatus = new ElementDefinitionInfo
                {
                    Name = "Element_BusinessStatus",
                    Path= "Task.businessStatus",
                    Id = "Task.businessStatus",
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
                // 10. Task.intent
                this.Element_Intent = new ElementDefinitionInfo
                {
                    Name = "Element_Intent",
                    Path= "Task.intent",
                    Id = "Task.intent",
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
                // 11. Task.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "Task.priority",
                    Id = "Task.priority",
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
                // 12. Task.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "Task.code",
                    Id = "Task.code",
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
                // 13. Task.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "Task.description",
                    Id = "Task.description",
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
                // 14. Task.focus
                this.Element_Focus = new ElementDefinitionInfo
                {
                    Name = "Element_Focus",
                    Path= "Task.focus",
                    Id = "Task.focus",
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
                // 15. Task.for
                this.Element_For = new ElementDefinitionInfo
                {
                    Name = "Element_For",
                    Path= "Task.for",
                    Id = "Task.for",
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
                // 16. Task.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "Task.encounter",
                    Id = "Task.encounter",
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
                // 17. Task.executionPeriod
                this.Element_ExecutionPeriod = new ElementDefinitionInfo
                {
                    Name = "Element_ExecutionPeriod",
                    Path= "Task.executionPeriod",
                    Id = "Task.executionPeriod",
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
                // 18. Task.authoredOn
                this.Element_AuthoredOn = new ElementDefinitionInfo
                {
                    Name = "Element_AuthoredOn",
                    Path= "Task.authoredOn",
                    Id = "Task.authoredOn",
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
                // 19. Task.lastModified
                this.Element_LastModified = new ElementDefinitionInfo
                {
                    Name = "Element_LastModified",
                    Path= "Task.lastModified",
                    Id = "Task.lastModified",
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
                // 20. Task.requester
                this.Element_Requester = new ElementDefinitionInfo
                {
                    Name = "Element_Requester",
                    Path= "Task.requester",
                    Id = "Task.requester",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Organization",
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
                // 21. Task.performerType
                this.Element_PerformerType = new ElementDefinitionInfo
                {
                    Name = "Element_PerformerType",
                    Path= "Task.performerType",
                    Id = "Task.performerType",
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
                // 22. Task.owner
                this.Element_Owner = new ElementDefinitionInfo
                {
                    Name = "Element_Owner",
                    Path= "Task.owner",
                    Id = "Task.owner",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/CareTeam",
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 23. Task.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "Task.location",
                    Id = "Task.location",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 24. Task.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "Task.reasonCode",
                    Id = "Task.reasonCode",
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
                // 25. Task.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "Task.reasonReference",
                    Id = "Task.reasonReference",
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
                // 26. Task.insurance
                this.Element_Insurance = new ElementDefinitionInfo
                {
                    Name = "Element_Insurance",
                    Path= "Task.insurance",
                    Id = "Task.insurance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Coverage",
                                "http://hl7.org/fhir/StructureDefinition/ClaimResponse"
                            }
                        }
                    }
                };
            }
            {
                // 27. Task.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Task.note",
                    Id = "Task.note",
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
                // 28. Task.relevantHistory
                this.Element_RelevantHistory = new ElementDefinitionInfo
                {
                    Name = "Element_RelevantHistory",
                    Path= "Task.relevantHistory",
                    Id = "Task.relevantHistory",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Provenance"
                            }
                        }
                    }
                };
            }
            {
                // 29. Task.restriction
                this.Element_Restriction = new ElementDefinitionInfo
                {
                    Name = "Element_Restriction",
                    Path= "Task.restriction",
                    Id = "Task.restriction",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Restriction
                        {
                        }
                    }
                };
            }
            {
                // 33. Task.input
                this.Element_Input = new ElementDefinitionInfo
                {
                    Name = "Element_Input",
                    Path= "Task.input",
                    Id = "Task.input",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Input
                        {
                        }
                    }
                };
            }
            {
                // 36. Task.output
                this.Element_Output = new ElementDefinitionInfo
                {
                    Name = "Element_Output",
                    Path= "Task.output",
                    Id = "Task.output",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Output
                        {
                        }
                    }
                };
            }
            this.Name = "Task";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Task";
        }
    }
}
