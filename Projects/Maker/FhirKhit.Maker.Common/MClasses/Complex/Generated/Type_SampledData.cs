using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'SampledData'
    /// </summary>
    // 0. SampledData
    public class Type_SampledData : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_SampledData_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. SampledData.origin
            public ElementDefinitionInfo Element_Origin;                                                                                    // MakerGen.cs:211
            // 2. SampledData.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:211
            // 3. SampledData.factor
            public ElementDefinitionInfo Element_Factor;                                                                                    // MakerGen.cs:211
            // 4. SampledData.lowerLimit
            public ElementDefinitionInfo Element_LowerLimit;                                                                                // MakerGen.cs:211
            // 5. SampledData.upperLimit
            public ElementDefinitionInfo Element_UpperLimit;                                                                                // MakerGen.cs:211
            // 6. SampledData.dimensions
            public ElementDefinitionInfo Element_Dimensions;                                                                                // MakerGen.cs:211
            // 7. SampledData.data
            public ElementDefinitionInfo Element_Data;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_SampledData_Elements()                                                                                              // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. SampledData.origin
                    this.Element_Origin = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Origin",                                                                                            // MakerGen.cs:230
                        Path= "SampledData.origin",                                                                                         // MakerGen.cs:231
                        Id = "SampledData.origin",                                                                                          // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. SampledData.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Period",                                                                                            // MakerGen.cs:230
                        Path= "SampledData.period",                                                                                         // MakerGen.cs:231
                        Id = "SampledData.period",                                                                                          // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. SampledData.factor
                    this.Element_Factor = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Factor",                                                                                            // MakerGen.cs:230
                        Path= "SampledData.factor",                                                                                         // MakerGen.cs:231
                        Id = "SampledData.factor",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. SampledData.lowerLimit
                    this.Element_LowerLimit = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_LowerLimit",                                                                                        // MakerGen.cs:230
                        Path= "SampledData.lowerLimit",                                                                                     // MakerGen.cs:231
                        Id = "SampledData.lowerLimit",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. SampledData.upperLimit
                    this.Element_UpperLimit = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_UpperLimit",                                                                                        // MakerGen.cs:230
                        Path= "SampledData.upperLimit",                                                                                     // MakerGen.cs:231
                        Id = "SampledData.upperLimit",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. SampledData.dimensions
                    this.Element_Dimensions = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Dimensions",                                                                                        // MakerGen.cs:230
                        Path= "SampledData.dimensions",                                                                                     // MakerGen.cs:231
                        Id = "SampledData.dimensions",                                                                                      // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. SampledData.data
                    this.Element_Data = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Data",                                                                                              // MakerGen.cs:230
                        Path= "SampledData.data",                                                                                           // MakerGen.cs:231
                        Id = "SampledData.data",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Origin.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Factor.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_LowerLimit.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_UpperLimit.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Dimensions.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Data.Write(sDef);                                                                                                   // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_SampledData_Elements Elements                                                                                           // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_SampledData_Elements();                                                                        // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_SampledData_Elements elements;                                                                                                 // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_SampledData()                                                                                                           // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "SampledData",                                                                                                       // MakerGen.cs:420
                ElementId = "SampledData"                                                                                                   // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
