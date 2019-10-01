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
      "id": "CarePlan",
      "url": "http://hl7.org/fhir/StructureDefinition/CarePlan",
      "version": "4.0.0",
      "name": "CarePlan",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "Describes the intention of how one or more practitioners intend to deliver care for a particular patient, group or community for a period of time, possibly limited to care for a specific condition or set of conditions.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CarePlan",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "CarePlan",
            "path": "CarePlan",
            "short": "Healthcare plan for patient or group",
            "definition": "Describes the intention of how one or more practitioners intend to deliver care for a particular patient, group or community for a period of time, possibly limited to care for a specific condition or set of conditions.",
            "alias": [
              "Care Team"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "CarePlan.identifier",
            "path": "CarePlan.identifier",
            "short": "External Ids for this plan",
            "definition": "Business identifiers assigned to this care plan by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the care plan as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "CarePlan.instantiatesCanonical",
            "path": "CarePlan.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a FHIR-defined protocol, guideline, questionnaire or other definition that is adhered to in whole or in part by this CarePlan.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire",
                  "http://hl7.org/fhir/StructureDefinition/Measure",
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/OperationDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CarePlan.instantiatesUri",
            "path": "CarePlan.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, questionnaire or other definition that is adhered to in whole or in part by this CarePlan.",
            "comment": "This might be an HTML page, PDF, etc. or could just be a non-resolvable URI identifier.",
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
            "id": "CarePlan.basedOn",
            "path": "CarePlan.basedOn",
            "short": "Fulfills CarePlan",
            "definition": "A care plan that is fulfilled in whole or in part by this care plan.",
            "requirements": "Allows tracing of the care plan and tracking whether proposals/recommendations were acted upon.",
            "alias": [
              "fulfills"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-hierarchy",
                    "valueBoolean": true
                  }
                ],
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CarePlan.replaces",
            "path": "CarePlan.replaces",
            "short": "CarePlan replaced by this CarePlan",
            "definition": "Completed or terminated care plan whose function is taken by this new care plan.",
            "comment": "The replacement could be because the initial care plan was immediately rejected (due to an issue) or because the previous care plan was completed, but the need for the action described by the care plan remains ongoing.",
            "requirements": "Allows tracing the continuation of a therapy or administrative process instantiated through multiple care plans.",
            "alias": [
              "supersedes"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-hierarchy",
                    "valueBoolean": true
                  }
                ],
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CarePlan.partOf",
            "path": "CarePlan.partOf",
            "short": "Part of referenced CarePlan",
            "definition": "A larger care plan of which this particular care plan is a component or step.",
            "comment": "Each care plan is an independent request, such that having a care plan be part of another care plan can cause issues with cascading statuses.  As such, this element is still being discussed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-hierarchy",
                    "valueBoolean": true
                  }
                ],
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CarePlan.status",
            "path": "CarePlan.status",
            "short": "draft | active | suspended | completed | entered-in-error | cancelled | unknown",
            "definition": "Indicates whether the plan is currently being acted upon, represents future intentions or is now a historical record.",
            "comment": "The unknown code is not to be used to convey other statuses.  The unknown code should be used when one of the statuses applies, but the authoring system doesn't know the current state of the care plan.\n\nThis element is labeled as a modifier because the status contains the code entered-in-error that marks the plan as not currently valid.",
            "requirements": "Allows clinicians to determine whether the plan is actionable or not.",
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
                  "valueString": "CarePlanStatus"
                }
              ],
              "strength": "required",
              "description": "Indicates whether the plan is currently being acted upon, represents future intentions or is now a historical record.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-status|4.0.0"
            }
          },
          {
            "id": "CarePlan.intent",
            "path": "CarePlan.intent",
            "short": "proposal | plan | order | option",
            "definition": "Indicates the level of authority/intentionality associated with the care plan and where the care plan fits into the workflow chain.",
            "comment": "This element is labeled as a modifier because the intent alters when and how the resource is actually applicable.",
            "requirements": "Proposals/recommendations, plans and orders all use the same structure and can exist in the same fulfillment chain.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element changes the interpretation of all descriptive attributes. For example \"the time the request is recommended to occur\" vs. \"the time the request is authorized to occur\" or \"who is recommended to perform the request\" vs. \"who is authorized to perform the request\"",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CarePlanIntent"
                }
              ],
              "strength": "required",
              "description": "Codes indicating the degree of authority/intentionality associated with a care plan.",
              "valueSet": "http://hl7.org/fhir/ValueSet/care-plan-intent|4.0.0"
            }
          },
          {
            "id": "CarePlan.category",
            "path": "CarePlan.category",
            "short": "Type of plan",
            "definition": "Identifies what \"kind\" of plan this is to support differentiation between multiple co-existing plans; e.g. \"Home health\", \"psychiatric\", \"asthma\", \"disease management\", \"wellness plan\", etc.",
            "comment": "There may be multiple axes of categorization and one plan may serve multiple purposes.  In some cases, this may be redundant with references to CarePlan.concern.",
            "requirements": "Used for filtering what plan(s) are retrieved and displayed to different types of users.",
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
                  "valueString": "CarePlanCategory"
                }
              ],
              "strength": "example",
              "description": "Identifies what \"kind\" of plan this is to support differentiation between multiple co-existing plans; e.g. \"Home health\", \"psychiatric\", \"asthma\", \"disease management\", etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/care-plan-category"
            }
          },
          {
            "id": "CarePlan.title",
            "path": "CarePlan.title",
            "short": "Human-friendly name for the care plan",
            "definition": "Human-friendly name for the care plan.",
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
            "id": "CarePlan.description",
            "path": "CarePlan.description",
            "short": "Summary of nature of plan",
            "definition": "A description of the scope and nature of the plan.",
            "requirements": "Provides more detail than conveyed by category.",
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
            "id": "CarePlan.subject",
            "path": "CarePlan.subject",
            "short": "Who the care plan is for",
            "definition": "Identifies the patient or group whose intended care is described by the plan.",
            "alias": [
              "patient"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CarePlan.encounter",
            "path": "CarePlan.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this CarePlan was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter. CarePlan activities conducted as a result of the care plan may well occur as part of other encounters.",
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
            "id": "CarePlan.period",
            "path": "CarePlan.period",
            "short": "Time period plan covers",
            "definition": "Indicates when the plan did (or is intended to) come into effect and end.",
            "comment": "Any activities scheduled as part of the plan should be constrained to the specified period regardless of whether the activities are planned within a single encounter/episode or across multiple encounters/episodes (e.g. the longitudinal management of a chronic condition).",
            "requirements": "Allows tracking what plan(s) are in effect at a particular time.",
            "alias": [
              "timing"
            ],
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
            "id": "CarePlan.created",
            "path": "CarePlan.created",
            "short": "Date record was first recorded",
            "definition": "Represents when this particular CarePlan record was created in the system, which is often a system-generated date.",
            "alias": [
              "authoredOn"
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
            "id": "CarePlan.author",
            "path": "CarePlan.author",
            "short": "Who is the designated responsible party",
            "definition": "When populated, the author is responsible for the care plan.  The care plan is attributed to the author.",
            "comment": "The author may also be a contributor.  For example, an organization can be an author, but not listed as a contributor.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CarePlan.contributor",
            "path": "CarePlan.contributor",
            "short": "Who provided the content of the care plan",
            "definition": "Identifies the individual(s) or organization who provided the contents of the care plan.",
            "comment": "Collaborative care plans may have multiple contributors.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.careTeam",
            "path": "CarePlan.careTeam",
            "short": "Who's involved in plan?",
            "definition": "Identifies all people and organizations who are expected to be involved in the care envisioned by this plan.",
            "requirements": "Allows representation of care teams, helps scope care plan.  In some cases may be a determiner of access permissions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CareTeam"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.addresses",
            "path": "CarePlan.addresses",
            "short": "Health issues this plan addresses",
            "definition": "Identifies the conditions/problems/concerns/diagnoses/etc. whose management and/or mitigation are handled by this plan.",
            "comment": "When the diagnosis is related to an allergy or intolerance, the Condition and AllergyIntolerance resources can both be used. However, to be actionable for decision support, using Condition alone is not sufficient as the allergy or intolerance condition needs to be represented as an AllergyIntolerance.",
            "requirements": "Links plan to the conditions it manages.  The element can identify risks addressed by the plan as well as active conditions.  (The Condition resource can include things like \"at risk for hypertension\" or \"fall risk\".)  Also scopes plans - multiple plans may exist addressing different concerns.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CarePlan.supportingInfo",
            "path": "CarePlan.supportingInfo",
            "short": "Information considered as part of plan",
            "definition": "Identifies portions of the patient's record that specifically influenced the formation of the plan.  These might include comorbidities, recent procedures, limitations, recent assessments, etc.",
            "comment": "Use \"concern\" to identify specific conditions addressed by the care plan.",
            "requirements": "Identifies barriers and other considerations associated with the care plan.",
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
            "id": "CarePlan.goal",
            "path": "CarePlan.goal",
            "short": "Desired outcome of plan",
            "definition": "Describes the intended objective(s) of carrying out the care plan.",
            "comment": "Goal can be achieving a particular change or merely maintaining a current state or even slowing a decline.",
            "requirements": "Provides context for plan.  Allows plan effectiveness to be evaluated by clinicians.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Goal"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.activity",
            "path": "CarePlan.activity",
            "short": "Action to occur as part of plan",
            "definition": "Identifies a planned action to occur as part of the plan.  For example, a medication to be used, lab tests to perform, self-monitoring, education, etc.",
            "requirements": "Allows systems to prompt for performance of planned activities, and validate plans against best practice.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CarePlan.activity.outcomeCodeableConcept",
            "path": "CarePlan.activity.outcomeCodeableConcept",
            "short": "Results of the activity",
            "definition": "Identifies the outcome at the point when the status of the activity is assessed.  For example, the outcome of an education activity could be patient understands (or not).",
            "comment": "Note that this should not duplicate the activity status (e.g. completed or in progress).",
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
                  "valueString": "CarePlanActivityOutcome"
                }
              ],
              "strength": "example",
              "description": "Identifies the results of the activity.",
              "valueSet": "http://hl7.org/fhir/ValueSet/care-plan-activity-outcome"
            }
          },
          {
            "id": "CarePlan.activity.outcomeReference",
            "path": "CarePlan.activity.outcomeReference",
            "short": "Appointment, Encounter, Procedure, etc.",
            "definition": "Details of the outcome or action resulting from the activity.  The reference to an \"event\" resource, such as Procedure or Encounter or Observation, is the result/outcome of the activity itself.  The activity can be conveyed using CarePlan.activity.detail OR using the CarePlan.activity.reference (a reference to a “request” resource).",
            "comment": "The activity outcome is independent of the outcome of the related goal(s).  For example, if the goal is to achieve a target body weight of 150 lbs and an activity is defined to diet, then the activity outcome could be calories consumed whereas the goal outcome is an observation for the actual body weight measured.",
            "requirements": "Links plan to resulting actions.",
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
            "id": "CarePlan.activity.progress",
            "path": "CarePlan.activity.progress",
            "short": "Comments about the activity status/progress",
            "definition": "Notes about the adherence/status/progress of the activity.",
            "comment": "This element should NOT be used to describe the activity to be performed - that occurs either within the resource pointed to by activity.detail.reference or in activity.detail.description.",
            "requirements": "Can be used to capture information about adherence, progress, concerns, etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "CarePlan.activity.reference",
            "path": "CarePlan.activity.reference",
            "short": "Activity details defined in specific resource",
            "definition": "The details of the proposed activity represented in a specific resource.",
            "comment": "Standard extension exists ([resource-pertainsToGoal](extension-resource-pertainstogoal.html)) that allows goals to be referenced from any of the referenced resources in CarePlan.activity.reference.  \rThe goal should be visible when the resource referenced by CarePlan.activity.reference is viewed independently from the CarePlan.  Requests that are pointed to by a CarePlan using this element should *not* point to this CarePlan using the \"basedOn\" element.  i.e. Requests that are part of a CarePlan are not \"based on\" the CarePlan.",
            "requirements": "Details in a form consistent with other applications and contexts of use.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Appointment",
                  "http://hl7.org/fhir/StructureDefinition/CommunicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/DeviceRequest",
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/NutritionOrder",
                  "http://hl7.org/fhir/StructureDefinition/Task",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                  "http://hl7.org/fhir/StructureDefinition/VisionPrescription",
                  "http://hl7.org/fhir/StructureDefinition/RequestGroup"
                ]
              }
            ],
            "condition": [
              "cpl-3"
            ]
          },
          {
            "id": "CarePlan.activity.detail",
            "path": "CarePlan.activity.detail",
            "short": "In-line definition of activity",
            "definition": "A simple summary of a planned activity suitable for a general care plan system (e.g. form driven) that doesn't know about specific resources such as procedure etc.",
            "requirements": "Details in a simple form for generic care plan systems.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "cpl-3"
            ]
          },
          {
            "id": "CarePlan.activity.detail.kind",
            "path": "CarePlan.activity.detail.kind",
            "short": "Kind of resource",
            "definition": "A description of the kind of resource the in-line definition of a care plan activity is representing.  The CarePlan.activity.detail is an in-line definition when a resource is not referenced using CarePlan.activity.reference.  For example, a MedicationRequest, a ServiceRequest, or a CommunicationRequest.",
            "requirements": "May determine what types of extensions are permitted.",
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
                  "valueString": "CarePlanActivityKind"
                }
              ],
              "strength": "required",
              "description": "Resource types defined as part of FHIR that can be represented as in-line definitions of a care plan activity.",
              "valueSet": "http://hl7.org/fhir/ValueSet/care-plan-activity-kind|4.0.0"
            }
          },
          {
            "id": "CarePlan.activity.detail.instantiatesCanonical",
            "path": "CarePlan.activity.detail.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a FHIR-defined protocol, guideline, questionnaire or other definition that is adhered to in whole or in part by this CarePlan activity.",
            "requirements": "Allows Questionnaires that the patient (or practitioner) should fill in to fulfill the care plan activity.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire",
                  "http://hl7.org/fhir/StructureDefinition/Measure",
                  "http://hl7.org/fhir/StructureDefinition/OperationDefinition"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.instantiatesUri",
            "path": "CarePlan.activity.detail.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, questionnaire or other definition that is adhered to in whole or in part by this CarePlan activity.",
            "comment": "This might be an HTML page, PDF, etc. or could just be a non-resolvable URI identifier.",
            "requirements": "Allows Questionnaires that the patient (or practitioner) should fill in to fulfill the care plan activity.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.code",
            "path": "CarePlan.activity.detail.code",
            "short": "Detail type of activity",
            "definition": "Detailed description of the type of planned activity; e.g. what lab test, what procedure, what kind of encounter.",
            "comment": "Tends to be less relevant for activities involving particular products.  Codes should not convey negation - use \"prohibited\" instead.",
            "requirements": "Allows matching performed to planned as well as validation against protocols.",
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
                  "valueString": "CarePlanActivityType"
                }
              ],
              "strength": "example",
              "description": "Detailed description of the type of activity; e.g. What lab test, what procedure, what kind of encounter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-code"
            }
          },
          {
            "id": "CarePlan.activity.detail.reasonCode",
            "path": "CarePlan.activity.detail.reasonCode",
            "short": "Why activity should be done or why activity was prohibited",
            "definition": "Provides the rationale that drove the inclusion of this particular activity as part of the plan or the reason why the activity was prohibited.",
            "comment": "This could be a diagnosis code.  If a full condition record exists or additional detail is needed, use reasonCondition instead.",
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
                  "valueString": "CarePlanActivityReason"
                }
              ],
              "strength": "example",
              "description": "Identifies why a care plan activity is needed.  Can include any health condition codes as well as such concepts as \"general wellness\", prophylaxis, surgical preparation, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "CarePlan.activity.detail.reasonReference",
            "path": "CarePlan.activity.detail.reasonReference",
            "short": "Why activity is needed",
            "definition": "Indicates another resource, such as the health condition(s), whose existence justifies this request and drove the inclusion of this particular activity as part of the plan.",
            "comment": "Conditions can be identified at the activity level that are not identified as reasons for the overall plan.",
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
            "id": "CarePlan.activity.detail.goal",
            "path": "CarePlan.activity.detail.goal",
            "short": "Goals this activity relates to",
            "definition": "Internal reference that identifies the goals that this activity is intended to contribute towards meeting.",
            "requirements": "So that participants know the link explicitly.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Goal"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.status",
            "path": "CarePlan.activity.detail.status",
            "short": "not-started | scheduled | in-progress | on-hold | completed | cancelled | stopped | unknown | entered-in-error",
            "definition": "Identifies what progress is being made for the specific activity.",
            "comment": "Some aspects of status can be inferred based on the resources linked in actionTaken.  Note that \"status\" is only as current as the plan was most recently updated.  \nThe unknown code is not to be used to convey other statuses.  The unknown code should be used when one of the statuses applies, but the authoring system doesn't know the current state of the activity.",
            "requirements": "Indicates progress against the plan, whether the activity is still relevant for the plan.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the activity should not be treated as valid",
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CarePlanActivityStatus"
                }
              ],
              "strength": "required",
              "description": "Codes that reflect the current state of a care plan activity within its overall life cycle.",
              "valueSet": "http://hl7.org/fhir/ValueSet/care-plan-activity-status|4.0.0"
            }
          },
          {
            "id": "CarePlan.activity.detail.statusReason",
            "path": "CarePlan.activity.detail.statusReason",
            "short": "Reason for current status",
            "definition": "Provides reason why the activity isn't yet started, is on hold, was cancelled, etc.",
            "comment": "Will generally not be present if status is \"complete\".  Be sure to prompt to update this (or at least remove the existing value) if the status is changed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.doNotPerform",
            "path": "CarePlan.activity.detail.doNotPerform",
            "short": "If true, activity is prohibiting action",
            "definition": "If true, indicates that the described activity is one that must NOT be engaged in when following the plan.  If false, or missing, indicates that the described activity is one that should be engaged in when following the plan.",
            "comment": "This element is labeled as a modifier because it marks an activity as an activity that is not to be performed.",
            "requirements": "Captures intention to not do something that may have been previously typical.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "If missing indicates that the described activity is one that should be engaged in when following the plan.",
            "isModifier": true,
            "isModifierReason": "If true this element negates the specified action. For example, instead of a request for a procedure, it is a request for the procedure to not occur."
          },
          {
            "id": "CarePlan.activity.detail.scheduled[x]",
            "path": "CarePlan.activity.detail.scheduled[x]",
            "short": "When activity is to occur",
            "definition": "The period, timing or frequency upon which the described activity is to occur.",
            "requirements": "Allows prompting for activities and detection of missed planned activities.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Timing"
              },
              {
                "code": "Period"
              },
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.location",
            "path": "CarePlan.activity.detail.location",
            "short": "Where it should happen",
            "definition": "Identifies the facility where the activity will occur; e.g. home, hospital, specific clinic, etc.",
            "comment": "May reference a specific clinical location or may identify a type of location.",
            "requirements": "Helps in planning of activity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.performer",
            "path": "CarePlan.activity.detail.performer",
            "short": "Who will be responsible?",
            "definition": "Identifies who's expected to be involved in the activity.",
            "comment": "A performer MAY also be a participant in the care plan.",
            "requirements": "Helps in planning of activity.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.product[x]",
            "path": "CarePlan.activity.detail.product[x]",
            "short": "What is to be administered/supplied",
            "definition": "Identifies the food, drug or other product to be consumed or supplied in the activity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CarePlanProduct"
                }
              ],
              "strength": "example",
              "description": "A product supplied or administered as part of a care plan activity.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-codes"
            }
          },
          {
            "id": "CarePlan.activity.detail.dailyAmount",
            "path": "CarePlan.activity.detail.dailyAmount",
            "short": "How to consume/day?",
            "definition": "Identifies the quantity expected to be consumed in a given day.",
            "requirements": "Allows rough dose checking.",
            "alias": [
              "daily dose"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.quantity",
            "path": "CarePlan.activity.detail.quantity",
            "short": "How much to administer/supply/consume",
            "definition": "Identifies the quantity expected to be supplied, administered or consumed by the subject.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "CarePlan.activity.detail.description",
            "path": "CarePlan.activity.detail.description",
            "short": "Extra info describing activity to perform",
            "definition": "This provides a textual description of constraints on the intended activity occurrence, including relation to other activities.  It may also include objectives, pre-conditions and end-conditions.  Finally, it may convey specifics about the activity such as body site, method, route, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CarePlan.note",
            "path": "CarePlan.note",
            "short": "Comments about the plan",
            "definition": "General notes about the care plan not covered elsewhere.",
            "requirements": "Used to capture information that applies to the plan as a whole that doesn't fit into discrete elements.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'CarePlan'
    /// </summary>
    // 0. CarePlan
    public class CarePlan : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class CarePlan_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 22. CarePlan.activity
            public class Type_Activity : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Activity_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 27. CarePlan.activity.detail
                    public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 28. CarePlan.activity.detail.kind
                            public ElementDefinitionInfo Kind;                                                                              // MakerGen.cs:211
                            // 29. CarePlan.activity.detail.instantiatesCanonical
                            public ElementDefinitionInfo InstantiatesCanonical;                                                             // MakerGen.cs:211
                            // 30. CarePlan.activity.detail.instantiatesUri
                            public ElementDefinitionInfo InstantiatesUri;                                                                   // MakerGen.cs:211
                            // 31. CarePlan.activity.detail.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:211
                            // 32. CarePlan.activity.detail.reasonCode
                            public ElementDefinitionInfo ReasonCode;                                                                        // MakerGen.cs:211
                            // 33. CarePlan.activity.detail.reasonReference
                            public ElementDefinitionInfo ReasonReference;                                                                   // MakerGen.cs:211
                            // 34. CarePlan.activity.detail.goal
                            public ElementDefinitionInfo Goal;                                                                              // MakerGen.cs:211
                            // 35. CarePlan.activity.detail.status
                            public ElementDefinitionInfo Status;                                                                            // MakerGen.cs:211
                            // 36. CarePlan.activity.detail.statusReason
                            public ElementDefinitionInfo StatusReason;                                                                      // MakerGen.cs:211
                            // 37. CarePlan.activity.detail.doNotPerform
                            public ElementDefinitionInfo DoNotPerform;                                                                      // MakerGen.cs:211
                            // 38. CarePlan.activity.detail.scheduled[x]
                            public ElementDefinitionInfo Scheduled;                                                                         // MakerGen.cs:211
                            // 39. CarePlan.activity.detail.location
                            public ElementDefinitionInfo Location;                                                                          // MakerGen.cs:211
                            // 40. CarePlan.activity.detail.performer
                            public ElementDefinitionInfo Performer;                                                                         // MakerGen.cs:211
                            // 41. CarePlan.activity.detail.product[x]
                            public ElementDefinitionInfo Product;                                                                           // MakerGen.cs:211
                            // 42. CarePlan.activity.detail.dailyAmount
                            public ElementDefinitionInfo DailyAmount;                                                                       // MakerGen.cs:211
                            // 43. CarePlan.activity.detail.quantity
                            public ElementDefinitionInfo Quantity;                                                                          // MakerGen.cs:211
                            // 44. CarePlan.activity.detail.description
                            public ElementDefinitionInfo Description;                                                                       // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Detail_Elements()                                                                                   // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 28. CarePlan.activity.detail.kind
                                    this.Kind = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Kind",                                                                                      // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.kind",                                                              // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.kind",                                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
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
                                    // 29. CarePlan.activity.detail.instantiatesCanonical
                                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "InstantiatesCanonical",                                                                     // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.instantiatesCanonical",                                             // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.instantiatesCanonical",                                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Canonical                                                   // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                                TargetProfile = new String[]                                                                // MakerGen.cs:298
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                               // MakerGen.cs:298
                                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                           // MakerGen.cs:298
                                                    "http://hl7.org/fhir/StructureDefinition/Questionnaire",                                // MakerGen.cs:298
                                                    "http://hl7.org/fhir/StructureDefinition/Measure",                                      // MakerGen.cs:298
                                                    "http://hl7.org/fhir/StructureDefinition/OperationDefinition"                           // MakerGen.cs:298
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 30. CarePlan.activity.detail.instantiatesUri
                                    this.InstantiatesUri = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "InstantiatesUri",                                                                           // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.instantiatesUri",                                                   // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.instantiatesUri",                                                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 31. CarePlan.activity.detail.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Code",                                                                                      // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.code",                                                              // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.code",                                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 32. CarePlan.activity.detail.reasonCode
                                    this.ReasonCode = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "ReasonCode",                                                                                // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.reasonCode",                                                        // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.reasonCode",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 33. CarePlan.activity.detail.reasonReference
                                    this.ReasonReference = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "ReasonReference",                                                                           // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.reasonReference",                                                   // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.reasonReference",                                                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                    // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                  // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                             // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                             // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 34. CarePlan.activity.detail.goal
                                    this.Goal = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Goal",                                                                                      // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.goal",                                                              // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.goal",                                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Goal"                                          // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 35. CarePlan.activity.detail.status
                                    this.Status = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Status",                                                                                    // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.status",                                                            // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.status",                                                             // MakerGen.cs:232
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
                                    // 36. CarePlan.activity.detail.statusReason
                                    this.StatusReason = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "StatusReason",                                                                              // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.statusReason",                                                      // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.statusReason",                                                       // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 37. CarePlan.activity.detail.doNotPerform
                                    this.DoNotPerform = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "DoNotPerform",                                                                              // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.doNotPerform",                                                      // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.doNotPerform",                                                       // MakerGen.cs:232
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
                                {                                                                                                           // MakerGen.cs:226
                                    // 38. CarePlan.activity.detail.scheduled[x]
                                    this.Scheduled = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Scheduled",                                                                                 // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.scheduled[x]",                                                      // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.scheduled[x]",                                                       // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Timing                                                        // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            },                                                                                              // MakerGen.cs:355
                                            new FhirKhit.Maker.Common.Complex.Period                                                        // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            },                                                                                              // MakerGen.cs:355
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 39. CarePlan.activity.detail.location
                                    this.Location = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Location",                                                                                  // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.location",                                                          // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.location",                                                           // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Location"                                      // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 40. CarePlan.activity.detail.performer
                                    this.Performer = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Performer",                                                                                 // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.performer",                                                         // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.performer",                                                          // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                 // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                             // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                 // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                      // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",                                     // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService",                            // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/Device"                                        // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 41. CarePlan.activity.detail.product[x]
                                    this.Product = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Product",                                                                                   // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.product[x]",                                                        // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.product[x]",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            },                                                                                              // MakerGen.cs:314
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                   // MakerGen.cs:344
                                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                     // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 42. CarePlan.activity.detail.dailyAmount
                                    this.DailyAmount = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "DailyAmount",                                                                               // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.dailyAmount",                                                       // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.dailyAmount",                                                        // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 43. CarePlan.activity.detail.quantity
                                    this.Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Quantity",                                                                                  // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.quantity",                                                          // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.quantity",                                                           // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 44. CarePlan.activity.detail.description
                                    this.Description = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Description",                                                                               // MakerGen.cs:230
                                        Path= "CarePlan.activity.detail.description",                                                       // MakerGen.cs:231
                                        Id = "CarePlan.activity.detail.description",                                                        // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
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
                                Kind.Write(sDef);                                                                                           // MakerGen.cs:215
                                InstantiatesCanonical.Write(sDef);                                                                          // MakerGen.cs:215
                                InstantiatesUri.Write(sDef);                                                                                // MakerGen.cs:215
                                Code.Write(sDef);                                                                                           // MakerGen.cs:215
                                ReasonCode.Write(sDef);                                                                                     // MakerGen.cs:215
                                ReasonReference.Write(sDef);                                                                                // MakerGen.cs:215
                                Goal.Write(sDef);                                                                                           // MakerGen.cs:215
                                Status.Write(sDef);                                                                                         // MakerGen.cs:215
                                StatusReason.Write(sDef);                                                                                   // MakerGen.cs:215
                                DoNotPerform.Write(sDef);                                                                                   // MakerGen.cs:215
                                Scheduled.Write(sDef);                                                                                      // MakerGen.cs:215
                                Location.Write(sDef);                                                                                       // MakerGen.cs:215
                                Performer.Write(sDef);                                                                                      // MakerGen.cs:215
                                Product.Write(sDef);                                                                                        // MakerGen.cs:215
                                DailyAmount.Write(sDef);                                                                                    // MakerGen.cs:215
                                Quantity.Write(sDef);                                                                                       // MakerGen.cs:215
                                Description.Write(sDef);                                                                                    // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Detail_Elements Elements                                                                                // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Detail_Elements();                                                             // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Detail_Elements elements;                                                                                      // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Detail()                                                                                                // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "CarePlan.activity.detail",                                                                          // MakerGen.cs:423
                                ElementId = "CarePlan.activity.detail"                                                                      // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 23. CarePlan.activity.outcomeCodeableConcept
                    public ElementDefinitionInfo OutcomeCodeableConcept;                                                                    // MakerGen.cs:211
                    // 24. CarePlan.activity.outcomeReference
                    public ElementDefinitionInfo OutcomeReference;                                                                          // MakerGen.cs:211
                    // 25. CarePlan.activity.progress
                    public ElementDefinitionInfo Progress;                                                                                  // MakerGen.cs:211
                    // 26. CarePlan.activity.reference
                    public ElementDefinitionInfo Reference;                                                                                 // MakerGen.cs:211
                    // 27. CarePlan.activity.detail
                    public ElementDefinitionInfo Detail;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Activity_Elements()                                                                                         // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. CarePlan.activity.outcomeCodeableConcept
                            this.OutcomeCodeableConcept = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "OutcomeCodeableConcept",                                                                            // MakerGen.cs:230
                                Path= "CarePlan.activity.outcomeCodeableConcept",                                                           // MakerGen.cs:231
                                Id = "CarePlan.activity.outcomeCodeableConcept",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. CarePlan.activity.outcomeReference
                            this.OutcomeReference = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "OutcomeReference",                                                                                  // MakerGen.cs:230
                                Path= "CarePlan.activity.outcomeReference",                                                                 // MakerGen.cs:231
                                Id = "CarePlan.activity.outcomeReference",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. CarePlan.activity.progress
                            this.Progress = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Progress",                                                                                          // MakerGen.cs:230
                                Path= "CarePlan.activity.progress",                                                                         // MakerGen.cs:231
                                Id = "CarePlan.activity.progress",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Annotation                                                            // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 26. CarePlan.activity.reference
                            this.Reference = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Reference",                                                                                         // MakerGen.cs:230
                                Path= "CarePlan.activity.reference",                                                                        // MakerGen.cs:231
                                Id = "CarePlan.activity.reference",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Appointment",                                          // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/CommunicationRequest",                                 // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/DeviceRequest",                                        // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/MedicationRequest",                                    // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/NutritionOrder",                                       // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Task",                                                 // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/ServiceRequest",                                       // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/VisionPrescription",                                   // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/RequestGroup"                                          // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 27. CarePlan.activity.detail
                            this.Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Detail",                                                                                            // MakerGen.cs:230
                                Path= "CarePlan.activity.detail",                                                                           // MakerGen.cs:231
                                Id = "CarePlan.activity.detail",                                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Detail                                                                                         // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        OutcomeCodeableConcept.Write(sDef);                                                                                 // MakerGen.cs:215
                        OutcomeReference.Write(sDef);                                                                                       // MakerGen.cs:215
                        Progress.Write(sDef);                                                                                               // MakerGen.cs:215
                        Reference.Write(sDef);                                                                                              // MakerGen.cs:215
                        Detail.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Activity_Elements Elements                                                                                      // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Activity_Elements();                                                                   // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Activity_Elements elements;                                                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Activity()                                                                                                      // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "CarePlan.activity",                                                                                         // MakerGen.cs:423
                        ElementId = "CarePlan.activity"                                                                                     // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. CarePlan.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. CarePlan.instantiatesCanonical
            public ElementDefinitionInfo InstantiatesCanonical;                                                                             // MakerGen.cs:211
            // 3. CarePlan.instantiatesUri
            public ElementDefinitionInfo InstantiatesUri;                                                                                   // MakerGen.cs:211
            // 4. CarePlan.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:211
            // 5. CarePlan.replaces
            public ElementDefinitionInfo Replaces;                                                                                          // MakerGen.cs:211
            // 6. CarePlan.partOf
            public ElementDefinitionInfo PartOf;                                                                                            // MakerGen.cs:211
            // 7. CarePlan.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 8. CarePlan.intent
            public ElementDefinitionInfo Intent;                                                                                            // MakerGen.cs:211
            // 9. CarePlan.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:211
            // 10. CarePlan.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 11. CarePlan.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 12. CarePlan.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:211
            // 13. CarePlan.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:211
            // 14. CarePlan.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:211
            // 15. CarePlan.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:211
            // 16. CarePlan.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:211
            // 17. CarePlan.contributor
            public ElementDefinitionInfo Contributor;                                                                                       // MakerGen.cs:211
            // 18. CarePlan.careTeam
            public ElementDefinitionInfo CareTeam;                                                                                          // MakerGen.cs:211
            // 19. CarePlan.addresses
            public ElementDefinitionInfo Addresses;                                                                                         // MakerGen.cs:211
            // 20. CarePlan.supportingInfo
            public ElementDefinitionInfo SupportingInfo;                                                                                    // MakerGen.cs:211
            // 21. CarePlan.goal
            public ElementDefinitionInfo Goal;                                                                                              // MakerGen.cs:211
            // 22. CarePlan.activity
            public ElementDefinitionInfo Activity;                                                                                          // MakerGen.cs:211
            // 45. CarePlan.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public CarePlan_Elements()                                                                                                      // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. CarePlan.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "CarePlan.identifier",                                                                                        // MakerGen.cs:231
                        Id = "CarePlan.identifier",                                                                                         // MakerGen.cs:232
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
                    // 2. CarePlan.instantiatesCanonical
                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "InstantiatesCanonical",                                                                                     // MakerGen.cs:230
                        Path= "CarePlan.instantiatesCanonical",                                                                             // MakerGen.cs:231
                        Id = "CarePlan.instantiatesCanonical",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                               // MakerGen.cs:298
                                    "http://hl7.org/fhir/StructureDefinition/Questionnaire",                                                // MakerGen.cs:298
                                    "http://hl7.org/fhir/StructureDefinition/Measure",                                                      // MakerGen.cs:298
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                           // MakerGen.cs:298
                                    "http://hl7.org/fhir/StructureDefinition/OperationDefinition"                                           // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. CarePlan.instantiatesUri
                    this.InstantiatesUri = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "InstantiatesUri",                                                                                           // MakerGen.cs:230
                        Path= "CarePlan.instantiatesUri",                                                                                   // MakerGen.cs:231
                        Id = "CarePlan.instantiatesUri",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. CarePlan.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:230
                        Path= "CarePlan.basedOn",                                                                                           // MakerGen.cs:231
                        Id = "CarePlan.basedOn",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. CarePlan.replaces
                    this.Replaces = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Replaces",                                                                                                  // MakerGen.cs:230
                        Path= "CarePlan.replaces",                                                                                          // MakerGen.cs:231
                        Id = "CarePlan.replaces",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. CarePlan.partOf
                    this.PartOf = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PartOf",                                                                                                    // MakerGen.cs:230
                        Path= "CarePlan.partOf",                                                                                            // MakerGen.cs:231
                        Id = "CarePlan.partOf",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. CarePlan.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "CarePlan.status",                                                                                            // MakerGen.cs:231
                        Id = "CarePlan.status",                                                                                             // MakerGen.cs:232
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
                    // 8. CarePlan.intent
                    this.Intent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Intent",                                                                                                    // MakerGen.cs:230
                        Path= "CarePlan.intent",                                                                                            // MakerGen.cs:231
                        Id = "CarePlan.intent",                                                                                             // MakerGen.cs:232
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
                    // 9. CarePlan.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Category",                                                                                                  // MakerGen.cs:230
                        Path= "CarePlan.category",                                                                                          // MakerGen.cs:231
                        Id = "CarePlan.category",                                                                                           // MakerGen.cs:232
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
                    // 10. CarePlan.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "CarePlan.title",                                                                                             // MakerGen.cs:231
                        Id = "CarePlan.title",                                                                                              // MakerGen.cs:232
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
                    // 11. CarePlan.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "CarePlan.description",                                                                                       // MakerGen.cs:231
                        Id = "CarePlan.description",                                                                                        // MakerGen.cs:232
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
                    // 12. CarePlan.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Subject",                                                                                                   // MakerGen.cs:230
                        Path= "CarePlan.subject",                                                                                           // MakerGen.cs:231
                        Id = "CarePlan.subject",                                                                                            // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. CarePlan.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Encounter",                                                                                                 // MakerGen.cs:230
                        Path= "CarePlan.encounter",                                                                                         // MakerGen.cs:231
                        Id = "CarePlan.encounter",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. CarePlan.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Period",                                                                                                    // MakerGen.cs:230
                        Path= "CarePlan.period",                                                                                            // MakerGen.cs:231
                        Id = "CarePlan.period",                                                                                             // MakerGen.cs:232
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
                    // 15. CarePlan.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Created",                                                                                                   // MakerGen.cs:230
                        Path= "CarePlan.created",                                                                                           // MakerGen.cs:231
                        Id = "CarePlan.created",                                                                                            // MakerGen.cs:232
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
                    // 16. CarePlan.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Author",                                                                                                    // MakerGen.cs:230
                        Path= "CarePlan.author",                                                                                            // MakerGen.cs:231
                        Id = "CarePlan.author",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. CarePlan.contributor
                    this.Contributor = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contributor",                                                                                               // MakerGen.cs:230
                        Path= "CarePlan.contributor",                                                                                       // MakerGen.cs:231
                        Id = "CarePlan.contributor",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. CarePlan.careTeam
                    this.CareTeam = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "CareTeam",                                                                                                  // MakerGen.cs:230
                        Path= "CarePlan.careTeam",                                                                                          // MakerGen.cs:231
                        Id = "CarePlan.careTeam",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. CarePlan.addresses
                    this.Addresses = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Addresses",                                                                                                 // MakerGen.cs:230
                        Path= "CarePlan.addresses",                                                                                         // MakerGen.cs:231
                        Id = "CarePlan.addresses",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition"                                                     // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. CarePlan.supportingInfo
                    this.SupportingInfo = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "SupportingInfo",                                                                                            // MakerGen.cs:230
                        Path= "CarePlan.supportingInfo",                                                                                    // MakerGen.cs:231
                        Id = "CarePlan.supportingInfo",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. CarePlan.goal
                    this.Goal = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Goal",                                                                                                      // MakerGen.cs:230
                        Path= "CarePlan.goal",                                                                                              // MakerGen.cs:231
                        Id = "CarePlan.goal",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Goal"                                                          // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. CarePlan.activity
                    this.Activity = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Activity",                                                                                                  // MakerGen.cs:230
                        Path= "CarePlan.activity",                                                                                          // MakerGen.cs:231
                        Id = "CarePlan.activity",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Activity                                                                                               // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 45. CarePlan.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Note",                                                                                                      // MakerGen.cs:230
                        Path= "CarePlan.note",                                                                                              // MakerGen.cs:231
                        Id = "CarePlan.note",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                InstantiatesCanonical.Write(sDef);                                                                                          // MakerGen.cs:215
                InstantiatesUri.Write(sDef);                                                                                                // MakerGen.cs:215
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:215
                Replaces.Write(sDef);                                                                                                       // MakerGen.cs:215
                PartOf.Write(sDef);                                                                                                         // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Intent.Write(sDef);                                                                                                         // MakerGen.cs:215
                Category.Write(sDef);                                                                                                       // MakerGen.cs:215
                Title.Write(sDef);                                                                                                          // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:215
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:215
                Period.Write(sDef);                                                                                                         // MakerGen.cs:215
                Created.Write(sDef);                                                                                                        // MakerGen.cs:215
                Author.Write(sDef);                                                                                                         // MakerGen.cs:215
                Contributor.Write(sDef);                                                                                                    // MakerGen.cs:215
                CareTeam.Write(sDef);                                                                                                       // MakerGen.cs:215
                Addresses.Write(sDef);                                                                                                      // MakerGen.cs:215
                SupportingInfo.Write(sDef);                                                                                                 // MakerGen.cs:215
                Goal.Write(sDef);                                                                                                           // MakerGen.cs:215
                Activity.Write(sDef);                                                                                                       // MakerGen.cs:215
                Note.Write(sDef);                                                                                                           // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public CarePlan_Elements Elements                                                                                                   // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new CarePlan_Elements();                                                                                // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        CarePlan_Elements elements;                                                                                                         // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public CarePlan()                                                                                                                   // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "CarePlan";                                                                                                         // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CarePlan";                                                                  // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "CarePlan",                                                                                                          // MakerGen.cs:423
                ElementId = "CarePlan"                                                                                                      // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
