using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'DeviceMetric'
    /// </summary>
    // 0. DeviceMetric
    public class DeviceMetric : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class DeviceMetric_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 10. DeviceMetric.calibration
            public class Type_Calibration : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Calibration_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 11. DeviceMetric.calibration.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 12. DeviceMetric.calibration.state
                    public ElementDefinitionInfo State;                                                                                     // MakerGen.cs:216
                    // 13. DeviceMetric.calibration.time
                    public ElementDefinitionInfo Time;                                                                                      // MakerGen.cs:216
                    public Type_Calibration_Elements()                                                                                      // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 11. DeviceMetric.calibration.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "DeviceMetric.calibration.type",                                                                      // MakerGen.cs:236
                                Id = "DeviceMetric.calibration.type",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. DeviceMetric.calibration.state
                            this.State = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "State",                                                                                             // MakerGen.cs:235
                                Path= "DeviceMetric.calibration.state",                                                                     // MakerGen.cs:236
                                Id = "DeviceMetric.calibration.state",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. DeviceMetric.calibration.time
                            this.Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Time",                                                                                              // MakerGen.cs:235
                                Path= "DeviceMetric.calibration.time",                                                                      // MakerGen.cs:236
                                Id = "DeviceMetric.calibration.time",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Instant                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        State.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Time.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Calibration_Elements Elements { get; }                                                                          // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Calibration()                                                                                                   // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Calibration_Elements();                                                                        // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. DeviceMetric.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. DeviceMetric.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 3. DeviceMetric.unit
            public ElementDefinitionInfo Unit;                                                                                              // MakerGen.cs:216
            // 4. DeviceMetric.source
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:216
            // 5. DeviceMetric.parent
            public ElementDefinitionInfo Parent;                                                                                            // MakerGen.cs:216
            // 6. DeviceMetric.operationalStatus
            public ElementDefinitionInfo OperationalStatus;                                                                                 // MakerGen.cs:216
            // 7. DeviceMetric.color
            public ElementDefinitionInfo Color;                                                                                             // MakerGen.cs:216
            // 8. DeviceMetric.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:216
            // 9. DeviceMetric.measurementPeriod
            public ElementDefinitionInfo MeasurementPeriod;                                                                                 // MakerGen.cs:216
            // 10. DeviceMetric.calibration
            public ElementDefinitionInfo Calibration;                                                                                       // MakerGen.cs:216
            public DeviceMetric_Elements()                                                                                                  // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. DeviceMetric.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "DeviceMetric.identifier",                                                                                    // MakerGen.cs:236
                        Id = "DeviceMetric.identifier",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. DeviceMetric.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "DeviceMetric.type",                                                                                          // MakerGen.cs:236
                        Id = "DeviceMetric.type",                                                                                           // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. DeviceMetric.unit
                    this.Unit = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Unit",                                                                                                      // MakerGen.cs:235
                        Path= "DeviceMetric.unit",                                                                                          // MakerGen.cs:236
                        Id = "DeviceMetric.unit",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. DeviceMetric.source
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Source",                                                                                                    // MakerGen.cs:235
                        Path= "DeviceMetric.source",                                                                                        // MakerGen.cs:236
                        Id = "DeviceMetric.source",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. DeviceMetric.parent
                    this.Parent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Parent",                                                                                                    // MakerGen.cs:235
                        Path= "DeviceMetric.parent",                                                                                        // MakerGen.cs:236
                        Id = "DeviceMetric.parent",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. DeviceMetric.operationalStatus
                    this.OperationalStatus = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OperationalStatus",                                                                                         // MakerGen.cs:235
                        Path= "DeviceMetric.operationalStatus",                                                                             // MakerGen.cs:236
                        Id = "DeviceMetric.operationalStatus",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 7. DeviceMetric.color
                    this.Color = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Color",                                                                                                     // MakerGen.cs:235
                        Path= "DeviceMetric.color",                                                                                         // MakerGen.cs:236
                        Id = "DeviceMetric.color",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 8. DeviceMetric.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Category",                                                                                                  // MakerGen.cs:235
                        Path= "DeviceMetric.category",                                                                                      // MakerGen.cs:236
                        Id = "DeviceMetric.category",                                                                                       // MakerGen.cs:237
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
                    // 9. DeviceMetric.measurementPeriod
                    this.MeasurementPeriod = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MeasurementPeriod",                                                                                         // MakerGen.cs:235
                        Path= "DeviceMetric.measurementPeriod",                                                                             // MakerGen.cs:236
                        Id = "DeviceMetric.measurementPeriod",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. DeviceMetric.calibration
                    this.Calibration = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Calibration",                                                                                               // MakerGen.cs:235
                        Path= "DeviceMetric.calibration",                                                                                   // MakerGen.cs:236
                        Id = "DeviceMetric.calibration",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Calibration                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Unit.Write(sDef);                                                                                                           // MakerGen.cs:220
                Source.Write(sDef);                                                                                                         // MakerGen.cs:220
                Parent.Write(sDef);                                                                                                         // MakerGen.cs:220
                OperationalStatus.Write(sDef);                                                                                              // MakerGen.cs:220
                Color.Write(sDef);                                                                                                          // MakerGen.cs:220
                Category.Write(sDef);                                                                                                       // MakerGen.cs:220
                MeasurementPeriod.Write(sDef);                                                                                              // MakerGen.cs:220
                Calibration.Write(sDef);                                                                                                    // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public DeviceMetric_Elements Elements { get; }                                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public DeviceMetric()                                                                                                               // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new DeviceMetric_Elements();                                                                                    // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
