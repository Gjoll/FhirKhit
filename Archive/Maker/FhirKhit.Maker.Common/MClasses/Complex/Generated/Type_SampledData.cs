using System;                                                                                                                               // MakerGen.cs:490
using System.Diagnostics;                                                                                                                   // MakerGen.cs:491
using System.IO;                                                                                                                            // MakerGen.cs:492
using System.Linq;                                                                                                                          // MakerGen.cs:493
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:494
                                                                                                                                            // MakerGen.cs:495
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:496
{                                                                                                                                           // MakerGen.cs:497
    #region Json                                                                                                                            // MakerGen.cs:498
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
    #endregion                                                                                                                              // MakerGen.cs:502
    /// <summary>
    /// Fhir complex 'SampledData'
    /// </summary>
    // 0. SampledData
    public partial class Type_SampledData : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. SampledData.origin
        public ElementDefinitionInfo Element_Origin;                                                                                        // MakerGen.cs:217
        // 2. SampledData.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:217
        // 3. SampledData.factor
        public ElementDefinitionInfo Element_Factor;                                                                                        // MakerGen.cs:217
        // 4. SampledData.lowerLimit
        public ElementDefinitionInfo Element_LowerLimit;                                                                                    // MakerGen.cs:217
        // 5. SampledData.upperLimit
        public ElementDefinitionInfo Element_UpperLimit;                                                                                    // MakerGen.cs:217
        // 6. SampledData.dimensions
        public ElementDefinitionInfo Element_Dimensions;                                                                                    // MakerGen.cs:217
        // 7. SampledData.data
        public ElementDefinitionInfo Element_Data;                                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "SampledData",                                                                                                       // MakerGen.cs:393
                ElementId = "SampledData"                                                                                                   // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Origin.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Factor.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_LowerLimit.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_UpperLimit.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Dimensions.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Data.Write(sDef);                                                                                                       // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Type_SampledData()                                                                                                           // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. SampledData.origin
                this.Element_Origin = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Origin",                                                                                                // MakerGen.cs:236
                    Path= "SampledData.origin",                                                                                             // MakerGen.cs:237
                    Id = "SampledData.origin",                                                                                              // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. SampledData.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Period",                                                                                                // MakerGen.cs:236
                    Path= "SampledData.period",                                                                                             // MakerGen.cs:237
                    Id = "SampledData.period",                                                                                              // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. SampledData.factor
                this.Element_Factor = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Factor",                                                                                                // MakerGen.cs:236
                    Path= "SampledData.factor",                                                                                             // MakerGen.cs:237
                    Id = "SampledData.factor",                                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. SampledData.lowerLimit
                this.Element_LowerLimit = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_LowerLimit",                                                                                            // MakerGen.cs:236
                    Path= "SampledData.lowerLimit",                                                                                         // MakerGen.cs:237
                    Id = "SampledData.lowerLimit",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. SampledData.upperLimit
                this.Element_UpperLimit = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_UpperLimit",                                                                                            // MakerGen.cs:236
                    Path= "SampledData.upperLimit",                                                                                         // MakerGen.cs:237
                    Id = "SampledData.upperLimit",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. SampledData.dimensions
                this.Element_Dimensions = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Dimensions",                                                                                            // MakerGen.cs:236
                    Path= "SampledData.dimensions",                                                                                         // MakerGen.cs:237
                    Id = "SampledData.dimensions",                                                                                          // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. SampledData.data
                this.Element_Data = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Data",                                                                                                  // MakerGen.cs:236
                    Path= "SampledData.data",                                                                                               // MakerGen.cs:237
                    Id = "SampledData.data",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:507
