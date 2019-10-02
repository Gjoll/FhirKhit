using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
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
    #endregion
    /// <summary>
    /// Fhir complex 'TriggerDefinition'
    /// </summary>
    // 0. TriggerDefinition
    public class Type_TriggerDefinition : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. TriggerDefinition.type
        public ElementDefinitionInfo Element_Type;
        // 2. TriggerDefinition.name
        public ElementDefinitionInfo Element_Name;
        // 3. TriggerDefinition.timing[x]
        public ElementDefinitionInfo Element_Timing;
        // 4. TriggerDefinition.data
        public ElementDefinitionInfo Element_Data;
        // 5. TriggerDefinition.condition
        public ElementDefinitionInfo Element_Condition;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "TriggerDefinition",
                ElementId = "TriggerDefinition"
            });
            Element_Type.Write(sDef);
            Element_Name.Write(sDef);
            Element_Timing.Write(sDef);
            Element_Data.Write(sDef);
            Element_Condition.Write(sDef);
        }
        
        public Type_TriggerDefinition()
        {
            {
                // 1. TriggerDefinition.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "TriggerDefinition.type",
                    Id = "TriggerDefinition.type",
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
                // 2. TriggerDefinition.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "TriggerDefinition.name",
                    Id = "TriggerDefinition.name",
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
                // 3. TriggerDefinition.timing[x]
                this.Element_Timing = new ElementDefinitionInfo
                {
                    Name = "Element_Timing",
                    Path= "TriggerDefinition.timing[x]",
                    Id = "TriggerDefinition.timing[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Schedule"
                            }
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 4. TriggerDefinition.data
                this.Element_Data = new ElementDefinitionInfo
                {
                    Name = "Element_Data",
                    Path= "TriggerDefinition.data",
                    Id = "TriggerDefinition.data",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                        {
                        }
                    }
                };
            }
            {
                // 5. TriggerDefinition.condition
                this.Element_Condition = new ElementDefinitionInfo
                {
                    Name = "Element_Condition",
                    Path= "TriggerDefinition.condition",
                    Id = "TriggerDefinition.condition",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Expression
                        {
                        }
                    }
                };
            }
        }
    }
}
