using System;                                                                                                                               // MakerGen.cs:461
using System.Diagnostics;                                                                                                                   // MakerGen.cs:462
using System.IO;                                                                                                                            // MakerGen.cs:463
using System.Linq;                                                                                                                          // MakerGen.cs:464
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:465
                                                                                                                                            // MakerGen.cs:466
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:467
{                                                                                                                                           // MakerGen.cs:468
    #region Json                                                                                                                            // MakerGen.cs:469
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
    #endregion                                                                                                                              // MakerGen.cs:473
    /// <summary>
    /// Fhir complex 'SampledData'
    /// </summary>
    // 0. SampledData
    public class SampledData : FhirKhit.Maker.Common.Complex.ComplexBase                                                                    // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 1. SampledData.origin
        public MakerElementInstance Element_Origin;                                                                                         // MakerGen.cs:232
        // 2. SampledData.period
        public MakerElementInstance Element_Period;                                                                                         // MakerGen.cs:232
        // 3. SampledData.factor
        public MakerElementInstance Element_Factor;                                                                                         // MakerGen.cs:232
        // 4. SampledData.lowerLimit
        public MakerElementInstance Element_LowerLimit;                                                                                     // MakerGen.cs:232
        // 5. SampledData.upperLimit
        public MakerElementInstance Element_UpperLimit;                                                                                     // MakerGen.cs:232
        // 6. SampledData.dimensions
        public MakerElementInstance Element_Dimensions;                                                                                     // MakerGen.cs:232
        // 7. SampledData.data
        public MakerElementInstance Element_Data;                                                                                           // MakerGen.cs:232
        public SampledData()                                                                                                                // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. SampledData.origin
                this.Element_Origin = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Origin",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Quantity                                                                          // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. SampledData.period
                this.Element_Period = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Period",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Decimal                                                                         // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. SampledData.factor
                this.Element_Factor = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Factor",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Decimal                                                                         // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 4. SampledData.lowerLimit
                this.Element_LowerLimit = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LowerLimit",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Decimal                                                                         // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 5. SampledData.upperLimit
                this.Element_UpperLimit = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_UpperLimit",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Decimal                                                                         // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 6. SampledData.dimensions
                this.Element_Dimensions = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Dimensions",                                                                                            // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                     // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 7. SampledData.data
                this.Element_Data = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Data",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:478
