using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
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
    public class TriggerDefinition_Type : Complex_Type                                                                                      // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. TriggerDefinition.type
        public ElementInstance Type;                                                                                                        // MakerGen.cs:203
        // 2. TriggerDefinition.name
        public ElementInstance Name;                                                                                                        // MakerGen.cs:203
        // 3. TriggerDefinition.timing[x]
        public ElementInstance TimingX;                                                                                                     // MakerGen.cs:203
        // 4. TriggerDefinition.data
        public ElementInstance Data;                                                                                                        // MakerGen.cs:203
        // 5. TriggerDefinition.condition
        public ElementInstance Condition;                                                                                                   // MakerGen.cs:203
        public TriggerDefinition_Type()                                                                                                     // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275
