using System;                                                                                                                               // MakerGen.cs:499
using System.Diagnostics;                                                                                                                   // MakerGen.cs:500
using System.IO;                                                                                                                            // MakerGen.cs:501
using System.Linq;                                                                                                                          // MakerGen.cs:502
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:503
                                                                                                                                            // MakerGen.cs:504
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:505
{                                                                                                                                           // MakerGen.cs:506
    #region Json                                                                                                                            // MakerGen.cs:507
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "SampledData",
      "url": "http://hl7.org/fhir/StructureDefinition/SampledData",
      "version": "4.0.0",
      "name": "SampledData",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for SampledData Type: A series of measurements taken by a device, with upper and lower limits. There may be more than one dimension in the data.",
      "purpose": "There is a need for a concise way to handle the data produced by devices that sample a physical state at a high frequency.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "SampledData",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SampledData",
            "path": "SampledData",
            "short": "A series of measurements taken by a device",
            "definition": "A series of measurements taken by a device, with upper and lower limits. There may be more than one dimension in the data.",
            "comment": "The data is not interpretable without at least origin, period, and dimensions, but these are optional to allow a separation between the template of measurement and the actual measurement, such as between DeviceCapabilities and DeviceLog.  When providing a summary view (for example with Observation.value[x]) SampledData should be represented with a brief display text such as \"Sampled Data\".",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SampledData.origin",
            "path": "SampledData.origin",
            "short": "Zero value and units",
            "definition": "The base quantity that a measured value of zero represents. In addition, this provides the units of the entire measurement series.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SampledData.period",
            "path": "SampledData.period",
            "short": "Number of milliseconds between samples",
            "definition": "The length of time between sampling times, measured in milliseconds.",
            "comment": "This is usually a whole number.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SampledData.factor",
            "path": "SampledData.factor",
            "short": "Multiply data by this before adding to origin",
            "definition": "A correction factor that is applied to the sampled data points before they are added to the origin.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "meaningWhenMissing": "If no factor is assigned, the data is not adjusted before adding to the origin",
            "isSummary": true
          },
          {
            "id": "SampledData.lowerLimit",
            "path": "SampledData.lowerLimit",
            "short": "Lower limit of detection",
            "definition": "The lower limit of detection of the measured points. This is needed if any of the data points have the value \"L\" (lower than detection limit).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SampledData.upperLimit",
            "path": "SampledData.upperLimit",
            "short": "Upper limit of detection",
            "definition": "The upper limit of detection of the measured points. This is needed if any of the data points have the value \"U\" (higher than detection limit).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SampledData.dimensions",
            "path": "SampledData.dimensions",
            "short": "Number of sample points at each time point",
            "definition": "The number of sample points at each time point. If this value is greater than one, then the dimensions will be interlaced - all the sample points for a point in time will be recorded at once.",
            "comment": "If there is more than one dimension, the code for the type of data will define the meaning of the dimensions (typically ECG data).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SampledData.data",
            "path": "SampledData.data",
            "short": "Decimal values with spaces, or \"E\" | \"U\" | \"L\"",
            "definition": "A series of data points which are decimal values separated by a single space (character u20). The special values \"E\" (error), \"L\" (below detection limit) and \"U\" (above detection limit) can also be used in place of a decimal value.",
            "comment": "Data may be missing if it is omitted for summarization purposes. In general, data is required for any actual use of a SampledData.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'SampledData'
    /// </summary>
    // 0. SampledData
    public class SampledData : FhirKhit.Maker.Common.Complex.ComplexBase                                                                    // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class SampledData_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                     // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. SampledData.origin
            public ElementDefinitionInfo Origin;                                                                                            // MakerGen.cs:236
            // 2. SampledData.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:236
            // 3. SampledData.factor
            public ElementDefinitionInfo Factor;                                                                                            // MakerGen.cs:236
            // 4. SampledData.lowerLimit
            public ElementDefinitionInfo LowerLimit;                                                                                        // MakerGen.cs:236
            // 5. SampledData.upperLimit
            public ElementDefinitionInfo UpperLimit;                                                                                        // MakerGen.cs:236
            // 6. SampledData.dimensions
            public ElementDefinitionInfo Dimensions;                                                                                        // MakerGen.cs:236
            // 7. SampledData.data
            public ElementDefinitionInfo Data;                                                                                              // MakerGen.cs:236
            public SampledData_Elements()                                                                                                   // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. SampledData.origin
                    this.Origin = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Origin",                                                                                                    // MakerGen.cs:255
                        Path= "SampledData.origin",                                                                                         // MakerGen.cs:256
                        Id = "SampledData.origin",                                                                                          // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. SampledData.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Period",                                                                                                    // MakerGen.cs:255
                        Path= "SampledData.period",                                                                                         // MakerGen.cs:256
                        Id = "SampledData.period",                                                                                          // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. SampledData.factor
                    this.Factor = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Factor",                                                                                                    // MakerGen.cs:255
                        Path= "SampledData.factor",                                                                                         // MakerGen.cs:256
                        Id = "SampledData.factor",                                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. SampledData.lowerLimit
                    this.LowerLimit = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "LowerLimit",                                                                                                // MakerGen.cs:255
                        Path= "SampledData.lowerLimit",                                                                                     // MakerGen.cs:256
                        Id = "SampledData.lowerLimit",                                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. SampledData.upperLimit
                    this.UpperLimit = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "UpperLimit",                                                                                                // MakerGen.cs:255
                        Path= "SampledData.upperLimit",                                                                                     // MakerGen.cs:256
                        Id = "SampledData.upperLimit",                                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. SampledData.dimensions
                    this.Dimensions = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Dimensions",                                                                                                // MakerGen.cs:255
                        Path= "SampledData.dimensions",                                                                                     // MakerGen.cs:256
                        Id = "SampledData.dimensions",                                                                                      // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. SampledData.data
                    this.Data = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Data",                                                                                                      // MakerGen.cs:255
                        Path= "SampledData.data",                                                                                           // MakerGen.cs:256
                        Id = "SampledData.data",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Origin.Write(sDef);                                                                                                         // MakerGen.cs:240
                Period.Write(sDef);                                                                                                         // MakerGen.cs:240
                Factor.Write(sDef);                                                                                                         // MakerGen.cs:240
                LowerLimit.Write(sDef);                                                                                                     // MakerGen.cs:240
                UpperLimit.Write(sDef);                                                                                                     // MakerGen.cs:240
                Dimensions.Write(sDef);                                                                                                     // MakerGen.cs:240
                Data.Write(sDef);                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public SampledData_Elements Elements { get; }                                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public SampledData()                                                                                                                // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new SampledData_Elements();                                                                                     // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
