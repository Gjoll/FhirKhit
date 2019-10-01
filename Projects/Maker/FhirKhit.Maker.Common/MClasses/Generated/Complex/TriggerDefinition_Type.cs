using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'TriggerDefinition'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "TriggerDefinition",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/TriggerDefinition",
    ///   "version": "4.0.0",
    ///   "name": "TriggerDefinition",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for TriggerDefinition Type: A description of a triggering event. Triggering events can be named events, data events, or periodic, as determined by the type element.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "TriggerDefinition",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "TriggerDefinition",
    ///         "path": "TriggerDefinition",
    ///         "short": "Defines an expected trigger for a module",
    ///         "definition": "A description of a triggering event. Triggering events can be named events, data events, or periodic, as determined by the type element.",
    ///         "comment": "If an event is a named-event, it means the event is completely pre-coordinated, and no other information can be specified for the event. If the event is one of the data- events, the data and condition elements specify the triggering criteria. The data element specifies the structured component, and the condition element provides additional optional refinement of that structured component. If the event is periodic, the timing element defines when the event is triggered. For both data- and periodic events, a name can be provided as a shorthand for the formal semantics provided by the other elements.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "TriggerDefinition.type",
    ///         "path": "TriggerDefinition.type",
    ///         "short": "named-event | periodic | data-changed | data-added | data-modified | data-removed | data-accessed | data-access-ended",
    ///         "definition": "The type of triggering event.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "TriggerType"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The type of trigger.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/trigger-type|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "TriggerDefinition.name",
    ///         "path": "TriggerDefinition.name",
    ///         "short": "Name or URI that identifies the event",
    ///         "definition": "A formal name for the event. This may be an absolute URI that identifies the event formally (e.g. from a trigger registry), or a simple relative URI that identifies the event in a local context.",
    ///         "comment": "An event name can be provided for all event types, but is required for named events. If a name is provided for a type other than named events, it is considered to be a shorthand for the semantics described by the formal description of the event.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "TriggerDefinition.timing[x]",
    ///         "path": "TriggerDefinition.timing[x]",
    ///         "short": "Timing of the event",
    ///         "definition": "The timing of the event (if this is a periodic trigger).",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Timing"
    ///           },
    ///           {
    ///             "code": "Reference",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/Schedule"
    ///             ]
    ///           },
    ///           {
    ///             "code": "date"
    ///           },
    ///           {
    ///             "code": "dateTime"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "TriggerDefinition.data",
    ///         "path": "TriggerDefinition.data",
    ///         "short": "Triggering data of the event (multiple = 'and')",
    ///         "definition": "The triggering data of the event (if this is a data trigger). If more than one data is requirement is specified, then all the data requirements must be true.",
    ///         "comment": "This element shall be present for any data type trigger.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "DataRequirement"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "TriggerDefinition.condition",
    ///         "path": "TriggerDefinition.condition",
    ///         "short": "Whether the event triggers (boolean expression)",
    ///         "definition": "A boolean-valued expression that is evaluated in the context of the container of the trigger definition and returns whether or not the trigger fires.",
    ///         "comment": "This element can be only be specified for data type triggers and provides additional semantics for the trigger. The context available within the condition is based on the type of data event. For all events, the current resource will be available as context. In addition, for modification events, the previous resource will also be available. The expression may be inlined, or may be a simple absolute URI, which is a reference to a named expression within a logic library referenced by a library element or extension within the containing resource. If the expression is a FHIR Path expression, it evaluates in the context of a resource of one of the type identified in the data requirement, and may also refer to the variable %previous for delta comparisons on events of type data-changed, data-modified, and data-deleted which will always have the same type.",
    ///         "requirements": "Need to be able to formally describe the triggering criteria.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Expression"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. TriggerDefinition
    public class TriggerDefinition_Type : MakerComplex_Type                                                                                 // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. TriggerDefinition.type
        public MakerElementInstance Type;                                                                                                   // MakerGen.cs:217
        // 2. TriggerDefinition.name
        public MakerElementInstance Name;                                                                                                   // MakerGen.cs:217
        // 3. TriggerDefinition.timing[x]
        public MakerElementInstance Timing;                                                                                                 // MakerGen.cs:217
        // 4. TriggerDefinition.data
        public MakerElementInstance Data;                                                                                                   // MakerGen.cs:217
        // 5. TriggerDefinition.condition
        public MakerElementInstance Condition;                                                                                              // MakerGen.cs:217
        public TriggerDefinition_Type()                                                                                                     // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. TriggerDefinition.type
                this.Type = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Type",                                                                                                          // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. TriggerDefinition.name
                this.Name = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Name",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. TriggerDefinition.timing[x]
                this.Timing = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Timing",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Date_Type(),
                        new DateTime_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. TriggerDefinition.data
                this.Data = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Data",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. TriggerDefinition.condition
                this.Condition = new MakerElementInstance                                                                                   // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Condition",                                                                                                     // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
