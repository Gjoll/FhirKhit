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
      "id": "DeviceMetric",
      "url": "http://hl7.org/fhir/StructureDefinition/DeviceMetric",
      "version": "4.0.0",
      "name": "DeviceMetric",
      "status": "draft",
      "publisher": "Health Level Seven International (Health Care Devices)",
      "description": "Describes a measurement, calculation or setting capability of a medical device.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "DeviceMetric",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DeviceMetric",
            "path": "DeviceMetric",
            "short": "Measurement, calculation or setting capability of a medical device",
            "definition": "Describes a measurement, calculation or setting capability of a medical device.",
            "comment": "For the initial scope, this DeviceMetric resource is only applicable to describe a single metric node in the containment tree that is produced by the context scanner in any medical device that implements or derives from the ISO/IEEE 11073 standard.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "DeviceMetric.identifier",
            "path": "DeviceMetric.identifier",
            "short": "Instance identifier",
            "definition": "Unique instance identifiers assigned to a device by the device or gateway software, manufacturers, other organizations or owners. For example: handle ID.",
            "comment": "For identifiers assigned to a device by the device or gateway software, the `system` element of the identifier should be set to the unique identifier of the device.",
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
            "id": "DeviceMetric.type",
            "path": "DeviceMetric.type",
            "short": "Identity of metric, for example Heart Rate or PEEP Setting",
            "definition": "Describes the type of the metric. For example: Heart Rate, PEEP Setting, etc.",
            "comment": "DeviceMetric.type can be referred to either IEEE 11073-10101 or LOINC.",
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
                  "valueString": "MetricType"
                }
              ],
              "strength": "preferred",
              "description": "Describes the metric type.",
              "valueSet": "http://hl7.org/fhir/ValueSet/devicemetric-type"
            }
          },
          {
            "id": "DeviceMetric.unit",
            "path": "DeviceMetric.unit",
            "short": "Unit of Measure for the Metric",
            "definition": "Describes the unit that an observed value determined for this metric will have. For example: Percent, Seconds, etc.",
            "comment": "DeviceMetric.unit can refer to either UCUM or preferable a RTMMS coding system.",
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
                  "valueString": "MetricUnit"
                }
              ],
              "strength": "preferred",
              "description": "Describes the unit of the metric.",
              "valueSet": "http://hl7.org/fhir/ValueSet/devicemetric-type"
            }
          },
          {
            "id": "DeviceMetric.source",
            "path": "DeviceMetric.source",
            "short": "Describes the link to the source Device",
            "definition": "Describes the link to the  Device that this DeviceMetric belongs to and that contains administrative device information such as manufacturer, serial number, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceMetric.parent",
            "path": "DeviceMetric.parent",
            "short": "Describes the link to the parent Device",
            "definition": "Describes the link to the  Device that this DeviceMetric belongs to and that provide information about the location of this DeviceMetric in the containment structure of the parent Device. An example would be a Device that represents a Channel. This reference can be used by a client application to distinguish DeviceMetrics that have the same type, but should be interpreted based on their containment location.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceMetric.operationalStatus",
            "path": "DeviceMetric.operationalStatus",
            "short": "on | off | standby | entered-in-error",
            "definition": "Indicates current operational state of the device. For example: On, Off, Standby, etc.",
            "min": 0,
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
                  "valueString": "DeviceMetricOperationalStatus"
                }
              ],
              "strength": "required",
              "description": "Describes the operational status of the DeviceMetric.",
              "valueSet": "http://hl7.org/fhir/ValueSet/metric-operational-status|4.0.0"
            }
          },
          {
            "id": "DeviceMetric.color",
            "path": "DeviceMetric.color",
            "short": "black | red | green | yellow | blue | magenta | cyan | white",
            "definition": "Describes the color representation for the metric. This is often used to aid clinicians to track and identify parameter types by color. In practice, consider a Patient Monitor that has ECG/HR and Pleth for example; the parameters are displayed in different characteristic colors, such as HR-blue, BP-green, and PR and SpO2- magenta.",
            "min": 0,
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
                  "valueString": "DeviceMetricColor"
                }
              ],
              "strength": "required",
              "description": "Describes the typical color of representation.",
              "valueSet": "http://hl7.org/fhir/ValueSet/metric-color|4.0.0"
            }
          },
          {
            "id": "DeviceMetric.category",
            "path": "DeviceMetric.category",
            "short": "measurement | setting | calculation | unspecified",
            "definition": "Indicates the category of the observation generation process. A DeviceMetric can be for example a setting, measurement, or calculation.",
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
                  "valueString": "DeviceMetricCategory"
                }
              ],
              "strength": "required",
              "description": "Describes the category of the metric.",
              "valueSet": "http://hl7.org/fhir/ValueSet/metric-category|4.0.0"
            }
          },
          {
            "id": "DeviceMetric.measurementPeriod",
            "path": "DeviceMetric.measurementPeriod",
            "short": "Describes the measurement repetition time",
            "definition": "Describes the measurement repetition time. This is not necessarily the same as the update period. The measurement repetition time can range from milliseconds up to hours. An example for a measurement repetition time in the range of milliseconds is the sampling rate of an ECG. An example for a measurement repetition time in the range of hours is a NIBP that is triggered automatically every hour. The update period may be different than the measurement repetition time, if the device does not update the published observed value with the same frequency as it was measured.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Timing"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceMetric.calibration",
            "path": "DeviceMetric.calibration",
            "short": "Describes the calibrations that have been performed or that are required to be performed",
            "definition": "Describes the calibrations that have been performed or that are required to be performed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceMetric.calibration.type",
            "path": "DeviceMetric.calibration.type",
            "short": "unspecified | offset | gain | two-point",
            "definition": "Describes the type of the calibration method.",
            "min": 0,
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
                  "valueString": "DeviceMetricCalibrationType"
                }
              ],
              "strength": "required",
              "description": "Describes the type of a metric calibration.",
              "valueSet": "http://hl7.org/fhir/ValueSet/metric-calibration-type|4.0.0"
            }
          },
          {
            "id": "DeviceMetric.calibration.state",
            "path": "DeviceMetric.calibration.state",
            "short": "not-calibrated | calibration-required | calibrated | unspecified",
            "definition": "Describes the state of the calibration.",
            "min": 0,
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
                  "valueString": "DeviceMetricCalibrationState"
                }
              ],
              "strength": "required",
              "description": "Describes the state of a metric calibration.",
              "valueSet": "http://hl7.org/fhir/ValueSet/metric-calibration-state|4.0.0"
            }
          },
          {
            "id": "DeviceMetric.calibration.time",
            "path": "DeviceMetric.calibration.time",
            "short": "Describes the time last calibration has been performed",
            "definition": "Describes the time last calibration has been performed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "instant"
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
    /// Fhir resource 'DeviceMetric'
    /// </summary>
    // 0. DeviceMetric
    public class Resource_DeviceMetric : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 10. DeviceMetric.calibration
        public class Type_Calibration : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. DeviceMetric.calibration.type
            public ElementDefinitionInfo Element_Type;
            // 12. DeviceMetric.calibration.state
            public ElementDefinitionInfo Element_State;
            // 13. DeviceMetric.calibration.time
            public ElementDefinitionInfo Element_Time;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DeviceMetric.calibration",
                    ElementId = "DeviceMetric.calibration"
                });
                Element_Type.Write(sDef);
                Element_State.Write(sDef);
                Element_Time.Write(sDef);
            }
            
            public Type_Calibration()
            {
                {
                    // 11. DeviceMetric.calibration.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "DeviceMetric.calibration.type",
                        Id = "DeviceMetric.calibration.type",
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
                    // 12. DeviceMetric.calibration.state
                    this.Element_State = new ElementDefinitionInfo
                    {
                        Name = "Element_State",
                        Path= "DeviceMetric.calibration.state",
                        Id = "DeviceMetric.calibration.state",
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
                    // 13. DeviceMetric.calibration.time
                    this.Element_Time = new ElementDefinitionInfo
                    {
                        Name = "Element_Time",
                        Path= "DeviceMetric.calibration.time",
                        Id = "DeviceMetric.calibration.time",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. DeviceMetric.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. DeviceMetric.type
        public ElementDefinitionInfo Element_Type;
        // 3. DeviceMetric.unit
        public ElementDefinitionInfo Element_Unit;
        // 4. DeviceMetric.source
        public ElementDefinitionInfo Element_Source;
        // 5. DeviceMetric.parent
        public ElementDefinitionInfo Element_Parent;
        // 6. DeviceMetric.operationalStatus
        public ElementDefinitionInfo Element_OperationalStatus;
        // 7. DeviceMetric.color
        public ElementDefinitionInfo Element_Color;
        // 8. DeviceMetric.category
        public ElementDefinitionInfo Element_Category;
        // 9. DeviceMetric.measurementPeriod
        public ElementDefinitionInfo Element_MeasurementPeriod;
        // 10. DeviceMetric.calibration
        public ElementDefinitionInfo Element_Calibration;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "DeviceMetric",
                ElementId = "DeviceMetric"
            });
            Element_Identifier.Write(sDef);
            Element_Type.Write(sDef);
            Element_Unit.Write(sDef);
            Element_Source.Write(sDef);
            Element_Parent.Write(sDef);
            Element_OperationalStatus.Write(sDef);
            Element_Color.Write(sDef);
            Element_Category.Write(sDef);
            Element_MeasurementPeriod.Write(sDef);
            Element_Calibration.Write(sDef);
        }
        
        public Resource_DeviceMetric()
        {
            {
                // 1. DeviceMetric.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "DeviceMetric.identifier",
                    Id = "DeviceMetric.identifier",
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
                // 2. DeviceMetric.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "DeviceMetric.type",
                    Id = "DeviceMetric.type",
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
                // 3. DeviceMetric.unit
                this.Element_Unit = new ElementDefinitionInfo
                {
                    Name = "Element_Unit",
                    Path= "DeviceMetric.unit",
                    Id = "DeviceMetric.unit",
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
                // 4. DeviceMetric.source
                this.Element_Source = new ElementDefinitionInfo
                {
                    Name = "Element_Source",
                    Path= "DeviceMetric.source",
                    Id = "DeviceMetric.source",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 5. DeviceMetric.parent
                this.Element_Parent = new ElementDefinitionInfo
                {
                    Name = "Element_Parent",
                    Path= "DeviceMetric.parent",
                    Id = "DeviceMetric.parent",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 6. DeviceMetric.operationalStatus
                this.Element_OperationalStatus = new ElementDefinitionInfo
                {
                    Name = "Element_OperationalStatus",
                    Path= "DeviceMetric.operationalStatus",
                    Id = "DeviceMetric.operationalStatus",
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
                // 7. DeviceMetric.color
                this.Element_Color = new ElementDefinitionInfo
                {
                    Name = "Element_Color",
                    Path= "DeviceMetric.color",
                    Id = "DeviceMetric.color",
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
                // 8. DeviceMetric.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "DeviceMetric.category",
                    Id = "DeviceMetric.category",
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
                // 9. DeviceMetric.measurementPeriod
                this.Element_MeasurementPeriod = new ElementDefinitionInfo
                {
                    Name = "Element_MeasurementPeriod",
                    Path= "DeviceMetric.measurementPeriod",
                    Id = "DeviceMetric.measurementPeriod",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        }
                    }
                };
            }
            {
                // 10. DeviceMetric.calibration
                this.Element_Calibration = new ElementDefinitionInfo
                {
                    Name = "Element_Calibration",
                    Path= "DeviceMetric.calibration",
                    Id = "DeviceMetric.calibration",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Calibration
                        {
                        }
                    }
                };
            }
            this.Name = "DeviceMetric";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DeviceMetric";
        }
    }
}
