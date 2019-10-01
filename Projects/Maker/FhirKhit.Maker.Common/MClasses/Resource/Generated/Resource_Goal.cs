using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
    {
      "resourceType": "StructureDefinition",
      "id": "Goal",
      "url": "http://hl7.org/fhir/StructureDefinition/Goal",
      "version": "4.0.0",
      "name": "Goal",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "Describes the intended objective(s) for a patient, group or organization care, for example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective, etc.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Goal",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Goal",
            "path": "Goal",
            "short": "Describes the intended objective(s) for a patient, group or organization",
            "definition": "Describes the intended objective(s) for a patient, group or organization care, for example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective, etc.",
            "comment": "Goal can be achieving a particular change or merely maintaining a current state or even slowing a decline.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Goal.identifier",
            "path": "Goal.identifier",
            "short": "External Ids for this goal",
            "definition": "Business identifiers assigned to this goal by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the goal as it is known by various participating systems and in a way that remains consistent across servers.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Goal.lifecycleStatus",
            "path": "Goal.lifecycleStatus",
            "short": "proposed | planned | accepted | active | on-hold | completed | cancelled | entered-in-error | rejected",
            "definition": "The state of the goal throughout its lifecycle.",
            "comment": "This element is labeled as a modifier because the lifecycleStatus contains codes that mark the resource as not currently valid.",
            "requirements": "Allows knowing whether goal needs to be further tracked.",
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
                  "valueString": "GoalLifecycleStatus"
                }
              ],
              "strength": "required",
              "description": "Codes that reflect the current state of a goal and whether the goal is still being targeted.",
              "valueSet": "http://hl7.org/fhir/ValueSet/goal-status|4.0.0"
            }
          },
          {
            "id": "Goal.achievementStatus",
            "path": "Goal.achievementStatus",
            "short": "in-progress | improving | worsening | no-change | achieved | sustaining | not-achieved | no-progress | not-attainable",
            "definition": "Describes the progression, or lack thereof, towards the goal against the target.",
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
                  "valueString": "GoalAchievementStatus"
                }
              ],
              "strength": "preferred",
              "description": "Indicates the progression, or lack thereof, towards the goal against the target.",
              "valueSet": "http://hl7.org/fhir/ValueSet/goal-achievement"
            }
          },
          {
            "id": "Goal.category",
            "path": "Goal.category",
            "short": "E.g. Treatment, dietary, behavioral, etc.",
            "definition": "Indicates a category the goal falls within.",
            "requirements": "Allows goals to be filtered and sorted.",
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
                  "valueString": "GoalCategory"
                }
              ],
              "strength": "example",
              "description": "Codes for grouping and sorting goals.",
              "valueSet": "http://hl7.org/fhir/ValueSet/goal-category"
            }
          },
          {
            "id": "Goal.priority",
            "path": "Goal.priority",
            "short": "high-priority | medium-priority | low-priority",
            "definition": "Identifies the mutually agreed level of importance associated with reaching/sustaining the goal.",
            "comment": "Extensions are available to track priorities as established by each participant (i.e. Priority from the patient's perspective, different practitioners' perspectives, family member's perspectives)\r\rThe ordinal extension on Coding can be used to convey a numerically comparable ranking to priority.  (Keep in mind that different coding systems may use a \"low value=important\".",
            "requirements": "Used for sorting and presenting goals.",
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
                  "valueString": "GoalPriority"
                }
              ],
              "strength": "preferred",
              "description": "The level of importance associated with a goal.",
              "valueSet": "http://hl7.org/fhir/ValueSet/goal-priority"
            }
          },
          {
            "id": "Goal.description",
            "path": "Goal.description",
            "short": "Code or text describing goal",
            "definition": "Human-readable and/or coded description of a specific desired objective of care, such as \"control blood pressure\" or \"negotiate an obstacle course\" or \"dance with child at wedding\".",
            "comment": "If no code is available, use CodeableConcept.text.",
            "requirements": "Without a description of what's trying to be achieved, element has no purpose.",
            "min": 1,
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
                  "valueString": "GoalDescription"
                }
              ],
              "strength": "example",
              "description": "Codes providing the details of a particular goal.  This will generally be system or implementation guide-specific.  In many systems, only the text element will be used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "Goal.subject",
            "path": "Goal.subject",
            "short": "Who this goal is intended for",
            "definition": "Identifies the patient, group or organization for whom the goal is being established.",
            "requirements": "Subject is optional to support annonymized reporting.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Goal.start[x]",
            "path": "Goal.start[x]",
            "short": "When goal pursuit begins",
            "definition": "The date or event after which the goal should begin being pursued.",
            "requirements": "Goals can be established prior to there being an intention to start pursuing them; e.g. Goals for post-surgical recovery established prior to surgery.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "GoalStartEvent"
                }
              ],
              "strength": "example",
              "description": "Codes describing events that can trigger the initiation of a goal.",
              "valueSet": "http://hl7.org/fhir/ValueSet/goal-start-event"
            }
          },
          {
            "id": "Goal.target",
            "path": "Goal.target",
            "short": "Target outcome for the goal",
            "definition": "Indicates what should be done by when.",
            "comment": "When multiple targets are present for a single goal instance, all targets must be met for the overall goal to be met.",
            "requirements": "Allows the progress of the goal to be monitored against an observation or due date.  Target is 0..* to support Observations with multiple components, such as blood pressure goals with both a systolic and diastolic target.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "gol-1"
            ]
          },
          {
            "id": "Goal.target.measure",
            "path": "Goal.target.measure",
            "short": "The parameter whose value is being tracked",
            "definition": "The parameter whose value is being tracked, e.g. body weight, blood pressure, or hemoglobin A1c level.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "gol-1"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "GoalTargetMeasure"
                }
              ],
              "strength": "example",
              "description": "Codes to identify the value being tracked, e.g. body weight, blood pressure, or hemoglobin A1c level.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-codes"
            }
          },
          {
            "id": "Goal.target.detail[x]",
            "path": "Goal.target.detail[x]",
            "short": "The target value to be achieved",
            "definition": "The target value of the focus to be achieved to signify the fulfillment of the goal, e.g. 150 pounds, 7.0%. Either the high or low or both values of the range can be specified. When a low value is missing, it indicates that the goal is achieved at any focus value at or below the high value. Similarly, if the high value is missing, it indicates that the goal is achieved at any focus value at or above the low value.",
            "comment": "A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Goal.target.measure defines a coded value.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "string"
              },
              {
                "code": "boolean"
              },
              {
                "code": "integer"
              },
              {
                "code": "Ratio"
              }
            ],
            "condition": [
              "gol-1"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "GoalTargetDetail"
                }
              ],
              "strength": "example",
              "description": "Codes to identify the target value of the focus to be achieved to signify the fulfillment of the goal."
            }
          },
          {
            "id": "Goal.target.due[x]",
            "path": "Goal.target.due[x]",
            "short": "Reach goal on or before",
            "definition": "Indicates either the date or the duration after start by which the goal should be met.",
            "requirements": "Identifies when the goal should be evaluated.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              },
              {
                "code": "Duration"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Goal.statusDate",
            "path": "Goal.statusDate",
            "short": "When goal status took effect",
            "definition": "Identifies when the current status.  I.e. When initially created, when achieved, when cancelled, etc.",
            "comment": "To see the date for past statuses, query history.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Goal.statusReason",
            "path": "Goal.statusReason",
            "short": "Reason for current status",
            "definition": "Captures the reason for the current status.",
            "comment": "This will typically be captured for statuses such as rejected, on-hold or cancelled, but could be present for others.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Goal.expressedBy",
            "path": "Goal.expressedBy",
            "short": "Who's responsible for creating Goal?",
            "definition": "Indicates whose goal this is - patient goal, practitioner goal, etc.",
            "comment": "This is the individual responsible for establishing the goal, not necessarily who recorded it.  (For that, use the Provenance resource.).",
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
            "id": "Goal.addresses",
            "path": "Goal.addresses",
            "short": "Issues addressed by this goal",
            "definition": "The identified conditions and other health record elements that are intended to be addressed by the goal.",
            "requirements": "Allows specific goals to explicitly linked to the concerns they're dealing with - makes the goal more understandable.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/MedicationStatement",
                  "http://hl7.org/fhir/StructureDefinition/NutritionOrder",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                  "http://hl7.org/fhir/StructureDefinition/RiskAssessment"
                ]
              }
            ]
          },
          {
            "id": "Goal.note",
            "path": "Goal.note",
            "short": "Comments about the goal",
            "definition": "Any comments related to the goal.",
            "comment": "May be used for progress notes, concerns or other related information that doesn't actually describe the goal itself.",
            "requirements": "There's a need to capture information about the goal that doesn't actually describe the goal.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "Goal.outcomeCode",
            "path": "Goal.outcomeCode",
            "short": "What result was achieved regarding the goal?",
            "definition": "Identifies the change (or lack of change) at the point when the status of the goal is assessed.",
            "comment": "Note that this should not duplicate the goal status.",
            "requirements": "Outcome tracking is a key aspect of care planning.",
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
                  "valueString": "GoalOutcome"
                }
              ],
              "strength": "example",
              "description": "The result of the goal; e.g. \"25% increase in shoulder mobility\", \"Anxiety reduced to moderate levels\".  \"15 kg weight loss sustained over 6 months\".",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "Goal.outcomeReference",
            "path": "Goal.outcomeReference",
            "short": "Observation that resulted from goal",
            "definition": "Details of what's changed (or not changed).",
            "comment": "The goal outcome is independent of the outcome of the related activities.  For example, if the Goal is to achieve a target body weight of 150 lb and a care plan activity is defined to diet, then the care plan’s activity outcome could be calories consumed whereas goal outcome is an observation for the actual body weight measured.",
            "requirements": "Outcome tracking is a key aspect of care planning.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Observation"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'Goal'
    /// </summary>
    // 0. Goal
    public class Resource_Goal : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_Goal_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 9. Goal.target
            public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Target_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 10. Goal.target.measure
                    public ElementDefinitionInfo Element_Measure;                                                                           // MakerGen.cs:211
                    // 11. Goal.target.detail[x]
                    public ElementDefinitionInfo Element_Detail;                                                                            // MakerGen.cs:211
                    // 12. Goal.target.due[x]
                    public ElementDefinitionInfo Element_Due;                                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Target_Elements()                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. Goal.target.measure
                            this.Element_Measure = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Measure",                                                                                   // MakerGen.cs:230
                                Path= "Goal.target.measure",                                                                                // MakerGen.cs:231
                                Id = "Goal.target.measure",                                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. Goal.target.detail[x]
                            this.Element_Detail = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Detail",                                                                                    // MakerGen.cs:230
                                Path= "Goal.target.detail[x]",                                                                              // MakerGen.cs:231
                                Id = "Goal.target.detail[x]",                                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    },                                                                                                      // MakerGen.cs:352
                                    new FhirKhit.Maker.Common.Complex.Type_Range                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    },                                                                                                      // MakerGen.cs:352
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    },                                                                                                      // MakerGen.cs:314
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. Goal.target.due[x]
                            this.Element_Due = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Due",                                                                                       // MakerGen.cs:230
                                Path= "Goal.target.due[x]",                                                                                 // MakerGen.cs:231
                                Id = "Goal.target.due[x]",                                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Type_Duration                                                         // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Measure.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_Detail.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Due.Write(sDef);                                                                                            // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Target_Elements Elements                                                                                        // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Target_Elements();                                                                     // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Target_Elements elements;                                                                                              // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Target()                                                                                                        // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Goal.target",                                                                                               // MakerGen.cs:420
                        ElementId = "Goal.target"                                                                                           // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. Goal.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. Goal.lifecycleStatus
            public ElementDefinitionInfo Element_LifecycleStatus;                                                                           // MakerGen.cs:211
            // 3. Goal.achievementStatus
            public ElementDefinitionInfo Element_AchievementStatus;                                                                         // MakerGen.cs:211
            // 4. Goal.category
            public ElementDefinitionInfo Element_Category;                                                                                  // MakerGen.cs:211
            // 5. Goal.priority
            public ElementDefinitionInfo Element_Priority;                                                                                  // MakerGen.cs:211
            // 6. Goal.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:211
            // 7. Goal.subject
            public ElementDefinitionInfo Element_Subject;                                                                                   // MakerGen.cs:211
            // 8. Goal.start[x]
            public ElementDefinitionInfo Element_Start;                                                                                     // MakerGen.cs:211
            // 9. Goal.target
            public ElementDefinitionInfo Element_Target;                                                                                    // MakerGen.cs:211
            // 13. Goal.statusDate
            public ElementDefinitionInfo Element_StatusDate;                                                                                // MakerGen.cs:211
            // 14. Goal.statusReason
            public ElementDefinitionInfo Element_StatusReason;                                                                              // MakerGen.cs:211
            // 15. Goal.expressedBy
            public ElementDefinitionInfo Element_ExpressedBy;                                                                               // MakerGen.cs:211
            // 16. Goal.addresses
            public ElementDefinitionInfo Element_Addresses;                                                                                 // MakerGen.cs:211
            // 17. Goal.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:211
            // 18. Goal.outcomeCode
            public ElementDefinitionInfo Element_OutcomeCode;                                                                               // MakerGen.cs:211
            // 19. Goal.outcomeReference
            public ElementDefinitionInfo Element_OutcomeReference;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_Goal_Elements()                                                                                                 // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Goal.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "Goal.identifier",                                                                                            // MakerGen.cs:231
                        Id = "Goal.identifier",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Goal.lifecycleStatus
                    this.Element_LifecycleStatus = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_LifecycleStatus",                                                                                   // MakerGen.cs:230
                        Path= "Goal.lifecycleStatus",                                                                                       // MakerGen.cs:231
                        Id = "Goal.lifecycleStatus",                                                                                        // MakerGen.cs:232
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
                    // 3. Goal.achievementStatus
                    this.Element_AchievementStatus = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_AchievementStatus",                                                                                 // MakerGen.cs:230
                        Path= "Goal.achievementStatus",                                                                                     // MakerGen.cs:231
                        Id = "Goal.achievementStatus",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Goal.category
                    this.Element_Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Category",                                                                                          // MakerGen.cs:230
                        Path= "Goal.category",                                                                                              // MakerGen.cs:231
                        Id = "Goal.category",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Goal.priority
                    this.Element_Priority = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Priority",                                                                                          // MakerGen.cs:230
                        Path= "Goal.priority",                                                                                              // MakerGen.cs:231
                        Id = "Goal.priority",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Goal.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Description",                                                                                       // MakerGen.cs:230
                        Path= "Goal.description",                                                                                           // MakerGen.cs:231
                        Id = "Goal.description",                                                                                            // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. Goal.subject
                    this.Element_Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subject",                                                                                           // MakerGen.cs:230
                        Path= "Goal.subject",                                                                                               // MakerGen.cs:231
                        Id = "Goal.subject",                                                                                                // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. Goal.start[x]
                    this.Element_Start = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Start",                                                                                             // MakerGen.cs:230
                        Path= "Goal.start[x]",                                                                                              // MakerGen.cs:231
                        Id = "Goal.start[x]",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. Goal.target
                    this.Element_Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Target",                                                                                            // MakerGen.cs:230
                        Path= "Goal.target",                                                                                                // MakerGen.cs:231
                        Id = "Goal.target",                                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Target                                                                                                 // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. Goal.statusDate
                    this.Element_StatusDate = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_StatusDate",                                                                                        // MakerGen.cs:230
                        Path= "Goal.statusDate",                                                                                            // MakerGen.cs:231
                        Id = "Goal.statusDate",                                                                                             // MakerGen.cs:232
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
                    // 14. Goal.statusReason
                    this.Element_StatusReason = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_StatusReason",                                                                                      // MakerGen.cs:230
                        Path= "Goal.statusReason",                                                                                          // MakerGen.cs:231
                        Id = "Goal.statusReason",                                                                                           // MakerGen.cs:232
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
                    // 15. Goal.expressedBy
                    this.Element_ExpressedBy = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ExpressedBy",                                                                                       // MakerGen.cs:230
                        Path= "Goal.expressedBy",                                                                                           // MakerGen.cs:231
                        Id = "Goal.expressedBy",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. Goal.addresses
                    this.Element_Addresses = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Addresses",                                                                                         // MakerGen.cs:230
                        Path= "Goal.addresses",                                                                                             // MakerGen.cs:231
                        Id = "Goal.addresses",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/MedicationStatement",                                          // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/NutritionOrder",                                               // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest",                                               // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/RiskAssessment"                                                // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. Goal.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Note",                                                                                              // MakerGen.cs:230
                        Path= "Goal.note",                                                                                                  // MakerGen.cs:231
                        Id = "Goal.note",                                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. Goal.outcomeCode
                    this.Element_OutcomeCode = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_OutcomeCode",                                                                                       // MakerGen.cs:230
                        Path= "Goal.outcomeCode",                                                                                           // MakerGen.cs:231
                        Id = "Goal.outcomeCode",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. Goal.outcomeReference
                    this.Element_OutcomeReference = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_OutcomeReference",                                                                                  // MakerGen.cs:230
                        Path= "Goal.outcomeReference",                                                                                      // MakerGen.cs:231
                        Id = "Goal.outcomeReference",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Observation"                                                   // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_LifecycleStatus.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_AchievementStatus.Write(sDef);                                                                                      // MakerGen.cs:215
                Element_Category.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Priority.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Start.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Target.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_StatusDate.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_StatusReason.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_ExpressedBy.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Addresses.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_OutcomeCode.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_OutcomeReference.Write(sDef);                                                                                       // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_Goal_Elements Elements                                                                                              // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_Goal_Elements();                                                                           // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_Goal_Elements elements;                                                                                                    // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_Goal()                                                                                                              // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "Goal";                                                                                                             // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Goal";                                                                      // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Goal",                                                                                                              // MakerGen.cs:420
                ElementId = "Goal"                                                                                                          // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
