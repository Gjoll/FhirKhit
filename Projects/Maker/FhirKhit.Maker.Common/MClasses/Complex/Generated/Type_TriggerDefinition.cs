using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "TriggerDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/TriggerDefinition",
      "version": "4.0.0",
      "name": "TriggerDefinition",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for TriggerDefinition Type: A description of a triggering event. Triggering events can be named events, data events, or periodic, as determined by the type element.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "TriggerDefinition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "TriggerDefinition",
            "path": "TriggerDefinition",
            "short": "Defines an expected trigger for a module",
            "definition": "A description of a triggering event. Triggering events can be named events, data events, or periodic, as determined by the type element.",
            "comment": "If an event is a named-event, it means the event is completely pre-coordinated, and no other information can be specified for the event. If the event is one of the data- events, the data and condition elements specify the triggering criteria. The data element specifies the structured component, and the condition element provides additional optional refinement of that structured component. If the event is periodic, the timing element defines when the event is triggered. For both data- and periodic events, a name can be provided as a shorthand for the formal semantics provided by the other elements.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "TriggerDefinition.type",
            "path": "TriggerDefinition.type",
            "short": "named-event | periodic | data-changed | data-added | data-modified | data-removed | data-accessed | data-access-ended",
            "definition": "The type of triggering event.",
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
                  "valueString": "TriggerType"
                }
              ],
              "strength": "required",
              "description": "The type of trigger.",
              "valueSet": "http://hl7.org/fhir/ValueSet/trigger-type|4.0.0"
            }
          },
          {
            "id": "TriggerDefinition.name",
            "path": "TriggerDefinition.name",
            "short": "Name or URI that identifies the event",
            "definition": "A formal name for the event. This may be an absolute URI that identifies the event formally (e.g. from a trigger registry), or a simple relative URI that identifies the event in a local context.",
            "comment": "An event name can be provided for all event types, but is required for named events. If a name is provided for a type other than named events, it is considered to be a shorthand for the semantics described by the formal description of the event.",
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
            "id": "TriggerDefinition.timing[x]",
            "path": "TriggerDefinition.timing[x]",
            "short": "Timing of the event",
            "definition": "The timing of the event (if this is a periodic trigger).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Timing"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Schedule"
                ]
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "TriggerDefinition.data",
            "path": "TriggerDefinition.data",
            "short": "Triggering data of the event (multiple = 'and')",
            "definition": "The triggering data of the event (if this is a data trigger). If more than one data is requirement is specified, then all the data requirements must be true.",
            "comment": "This element shall be present for any data type trigger.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "DataRequirement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "TriggerDefinition.condition",
            "path": "TriggerDefinition.condition",
            "short": "Whether the event triggers (boolean expression)",
            "definition": "A boolean-valued expression that is evaluated in the context of the container of the trigger definition and returns whether or not the trigger fires.",
            "comment": "This element can be only be specified for data type triggers and provides additional semantics for the trigger. The context available within the condition is based on the type of data event. For all events, the current resource will be available as context. In addition, for modification events, the previous resource will also be available. The expression may be inlined, or may be a simple absolute URI, which is a reference to a named expression within a logic library referenced by a library element or extension within the containing resource. If the expression is a FHIR Path expression, it evaluates in the context of a resource of one of the type identified in the data requirement, and may also refer to the variable %previous for delta comparisons on events of type data-changed, data-modified, and data-deleted which will always have the same type.",
            "requirements": "Need to be able to formally describe the triggering criteria.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Expression"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'TriggerDefinition'
    /// </summary>
    // 0. TriggerDefinition
    public class Type_TriggerDefinition : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. TriggerDefinition.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 2. TriggerDefinition.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 3. TriggerDefinition.timing[x]
        public ElementDefinitionInfo Element_Timing;                                                                                        // MakerGen.cs:212
        // 4. TriggerDefinition.data
        public ElementDefinitionInfo Element_Data;                                                                                          // MakerGen.cs:212
        // 5. TriggerDefinition.condition
        public ElementDefinitionInfo Element_Condition;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "TriggerDefinition",                                                                                                 // MakerGen.cs:388
                ElementId = "TriggerDefinition"                                                                                             // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Timing.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Data.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Condition.Write(sDef);                                                                                                  // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_TriggerDefinition()                                                                                                     // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. TriggerDefinition.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "TriggerDefinition.type",                                                                                         // MakerGen.cs:232
                    Id = "TriggerDefinition.type",                                                                                          // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. TriggerDefinition.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "TriggerDefinition.name",                                                                                         // MakerGen.cs:232
                    Id = "TriggerDefinition.name",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. TriggerDefinition.timing[x]
                this.Element_Timing = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Timing",                                                                                                // MakerGen.cs:231
                    Path= "TriggerDefinition.timing[x]",                                                                                    // MakerGen.cs:232
                    Id = "TriggerDefinition.timing[x]",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Timing                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Schedule"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        },                                                                                                                  // MakerGen.cs:343
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. TriggerDefinition.data
                this.Element_Data = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Data",                                                                                                  // MakerGen.cs:231
                    Path= "TriggerDefinition.data",                                                                                         // MakerGen.cs:232
                    Id = "TriggerDefinition.data",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_DataRequirement                                                              // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. TriggerDefinition.condition
                this.Element_Condition = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Condition",                                                                                             // MakerGen.cs:231
                    Path= "TriggerDefinition.condition",                                                                                    // MakerGen.cs:232
                    Id = "TriggerDefinition.condition",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Expression                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
