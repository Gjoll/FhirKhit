using System;                                                                                                                               // MakerGen.cs:497
using System.Diagnostics;                                                                                                                   // MakerGen.cs:498
using System.IO;                                                                                                                            // MakerGen.cs:499
using System.Linq;                                                                                                                          // MakerGen.cs:500
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:501
                                                                                                                                            // MakerGen.cs:502
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:503
{                                                                                                                                           // MakerGen.cs:504
    #region Json                                                                                                                            // MakerGen.cs:505
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
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'TriggerDefinition'
    /// </summary>
    // 0. TriggerDefinition
    public class TriggerDefinition : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class TriggerDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. TriggerDefinition.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 2. TriggerDefinition.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 3. TriggerDefinition.timing[x]
            public ElementDefinitionInfo Timing;                                                                                            // MakerGen.cs:216
            // 4. TriggerDefinition.data
            public ElementDefinitionInfo Data;                                                                                              // MakerGen.cs:216
            // 5. TriggerDefinition.condition
            public ElementDefinitionInfo Condition;                                                                                         // MakerGen.cs:216
            public TriggerDefinition_Elements()                                                                                             // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. TriggerDefinition.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "TriggerDefinition.type",                                                                                     // MakerGen.cs:236
                        Id = "TriggerDefinition.type",                                                                                      // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. TriggerDefinition.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "TriggerDefinition.name",                                                                                     // MakerGen.cs:236
                        Id = "TriggerDefinition.name",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. TriggerDefinition.timing[x]
                    this.Timing = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Timing",                                                                                                    // MakerGen.cs:235
                        Path= "TriggerDefinition.timing[x]",                                                                                // MakerGen.cs:236
                        Id = "TriggerDefinition.timing[x]",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Schedule"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            },                                                                                                              // MakerGen.cs:350
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. TriggerDefinition.data
                    this.Data = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Data",                                                                                                      // MakerGen.cs:235
                        Path= "TriggerDefinition.data",                                                                                     // MakerGen.cs:236
                        Id = "TriggerDefinition.data",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.DataRequirement                                                               // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. TriggerDefinition.condition
                    this.Condition = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Condition",                                                                                                 // MakerGen.cs:235
                        Path= "TriggerDefinition.condition",                                                                                // MakerGen.cs:236
                        Id = "TriggerDefinition.condition",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Expression                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Timing.Write(sDef);                                                                                                         // MakerGen.cs:220
                Data.Write(sDef);                                                                                                           // MakerGen.cs:220
                Condition.Write(sDef);                                                                                                      // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public TriggerDefinition_Elements Elements { get; }                                                                                 // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public TriggerDefinition()                                                                                                          // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new TriggerDefinition_Elements();                                                                               // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
