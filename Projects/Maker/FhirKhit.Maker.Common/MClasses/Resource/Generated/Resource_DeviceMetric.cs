using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'DeviceMetric'
    /// </summary>
    // 0. DeviceMetric
    public class Resource_DeviceMetric : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 10. DeviceMetric.calibration
        public class Type_Calibration : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 11. DeviceMetric.calibration.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 12. DeviceMetric.calibration.state
            public ElementDefinitionInfo Element_State;                                                                                     // MakerGen.cs:212
            // 13. DeviceMetric.calibration.time
            public ElementDefinitionInfo Element_Time;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "DeviceMetric.calibration",                                                                                      // MakerGen.cs:388
                    ElementId = "DeviceMetric.calibration"                                                                                  // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_State.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Time.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Calibration()                                                                                                       // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 11. DeviceMetric.calibration.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "DeviceMetric.calibration.type",                                                                              // MakerGen.cs:232
                        Id = "DeviceMetric.calibration.type",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. DeviceMetric.calibration.state
                    this.Element_State = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_State",                                                                                             // MakerGen.cs:231
                        Path= "DeviceMetric.calibration.state",                                                                             // MakerGen.cs:232
                        Id = "DeviceMetric.calibration.state",                                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 13. DeviceMetric.calibration.time
                    this.Element_Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Time",                                                                                              // MakerGen.cs:231
                        Path= "DeviceMetric.calibration.time",                                                                              // MakerGen.cs:232
                        Id = "DeviceMetric.calibration.time",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. DeviceMetric.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. DeviceMetric.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 3. DeviceMetric.unit
        public ElementDefinitionInfo Element_Unit;                                                                                          // MakerGen.cs:212
        // 4. DeviceMetric.source
        public ElementDefinitionInfo Element_Source;                                                                                        // MakerGen.cs:212
        // 5. DeviceMetric.parent
        public ElementDefinitionInfo Element_Parent;                                                                                        // MakerGen.cs:212
        // 6. DeviceMetric.operationalStatus
        public ElementDefinitionInfo Element_OperationalStatus;                                                                             // MakerGen.cs:212
        // 7. DeviceMetric.color
        public ElementDefinitionInfo Element_Color;                                                                                         // MakerGen.cs:212
        // 8. DeviceMetric.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 9. DeviceMetric.measurementPeriod
        public ElementDefinitionInfo Element_MeasurementPeriod;                                                                             // MakerGen.cs:212
        // 10. DeviceMetric.calibration
        public ElementDefinitionInfo Element_Calibration;                                                                                   // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "DeviceMetric",                                                                                                      // MakerGen.cs:388
                ElementId = "DeviceMetric"                                                                                                  // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Unit.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Source.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Parent.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_OperationalStatus.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_Color.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_MeasurementPeriod.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_Calibration.Write(sDef);                                                                                                // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_DeviceMetric()                                                                                                      // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. DeviceMetric.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "DeviceMetric.identifier",                                                                                        // MakerGen.cs:232
                    Id = "DeviceMetric.identifier",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. DeviceMetric.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "DeviceMetric.type",                                                                                              // MakerGen.cs:232
                    Id = "DeviceMetric.type",                                                                                               // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. DeviceMetric.unit
                this.Element_Unit = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Unit",                                                                                                  // MakerGen.cs:231
                    Path= "DeviceMetric.unit",                                                                                              // MakerGen.cs:232
                    Id = "DeviceMetric.unit",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. DeviceMetric.source
                this.Element_Source = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Source",                                                                                                // MakerGen.cs:231
                    Path= "DeviceMetric.source",                                                                                            // MakerGen.cs:232
                    Id = "DeviceMetric.source",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. DeviceMetric.parent
                this.Element_Parent = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Parent",                                                                                                // MakerGen.cs:231
                    Path= "DeviceMetric.parent",                                                                                            // MakerGen.cs:232
                    Id = "DeviceMetric.parent",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. DeviceMetric.operationalStatus
                this.Element_OperationalStatus = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_OperationalStatus",                                                                                     // MakerGen.cs:231
                    Path= "DeviceMetric.operationalStatus",                                                                                 // MakerGen.cs:232
                    Id = "DeviceMetric.operationalStatus",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
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
                // 7. DeviceMetric.color
                this.Element_Color = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Color",                                                                                                 // MakerGen.cs:231
                    Path= "DeviceMetric.color",                                                                                             // MakerGen.cs:232
                    Id = "DeviceMetric.color",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
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
                // 8. DeviceMetric.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "DeviceMetric.category",                                                                                          // MakerGen.cs:232
                    Id = "DeviceMetric.category",                                                                                           // MakerGen.cs:233
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
                // 9. DeviceMetric.measurementPeriod
                this.Element_MeasurementPeriod = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_MeasurementPeriod",                                                                                     // MakerGen.cs:231
                    Path= "DeviceMetric.measurementPeriod",                                                                                 // MakerGen.cs:232
                    Id = "DeviceMetric.measurementPeriod",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Timing                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. DeviceMetric.calibration
                this.Element_Calibration = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Calibration",                                                                                           // MakerGen.cs:231
                    Path= "DeviceMetric.calibration",                                                                                       // MakerGen.cs:232
                    Id = "DeviceMetric.calibration",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Calibration                                                                                                // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "DeviceMetric";                                                                                                     // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DeviceMetric";                                                              // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
