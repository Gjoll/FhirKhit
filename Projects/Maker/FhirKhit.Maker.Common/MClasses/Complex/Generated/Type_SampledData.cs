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
    #endregion
    /// <summary>
    /// Fhir complex 'SampledData'
    /// </summary>
    // 0. SampledData
    public class Type_SampledData : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. SampledData.origin
        public ElementDefinitionInfo Element_Origin;
        // 2. SampledData.period
        public ElementDefinitionInfo Element_Period;
        // 3. SampledData.factor
        public ElementDefinitionInfo Element_Factor;
        // 4. SampledData.lowerLimit
        public ElementDefinitionInfo Element_LowerLimit;
        // 5. SampledData.upperLimit
        public ElementDefinitionInfo Element_UpperLimit;
        // 6. SampledData.dimensions
        public ElementDefinitionInfo Element_Dimensions;
        // 7. SampledData.data
        public ElementDefinitionInfo Element_Data;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SampledData",
                ElementId = "SampledData"
            });
            Element_Origin.Write(sDef);
            Element_Period.Write(sDef);
            Element_Factor.Write(sDef);
            Element_LowerLimit.Write(sDef);
            Element_UpperLimit.Write(sDef);
            Element_Dimensions.Write(sDef);
            Element_Data.Write(sDef);
        }
        
        public Type_SampledData()
        {
            {
                // 1. SampledData.origin
                this.Element_Origin = new ElementDefinitionInfo
                {
                    Name = "Element_Origin",
                    Path= "SampledData.origin",
                    Id = "SampledData.origin",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
            {
                // 2. SampledData.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "SampledData.period",
                    Id = "SampledData.period",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        }
                    }
                };
            }
            {
                // 3. SampledData.factor
                this.Element_Factor = new ElementDefinitionInfo
                {
                    Name = "Element_Factor",
                    Path= "SampledData.factor",
                    Id = "SampledData.factor",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        }
                    }
                };
            }
            {
                // 4. SampledData.lowerLimit
                this.Element_LowerLimit = new ElementDefinitionInfo
                {
                    Name = "Element_LowerLimit",
                    Path= "SampledData.lowerLimit",
                    Id = "SampledData.lowerLimit",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        }
                    }
                };
            }
            {
                // 5. SampledData.upperLimit
                this.Element_UpperLimit = new ElementDefinitionInfo
                {
                    Name = "Element_UpperLimit",
                    Path= "SampledData.upperLimit",
                    Id = "SampledData.upperLimit",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        }
                    }
                };
            }
            {
                // 6. SampledData.dimensions
                this.Element_Dimensions = new ElementDefinitionInfo
                {
                    Name = "Element_Dimensions",
                    Path= "SampledData.dimensions",
                    Id = "SampledData.dimensions",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        }
                    }
                };
            }
            {
                // 7. SampledData.data
                this.Element_Data = new ElementDefinitionInfo
                {
                    Name = "Element_Data",
                    Path= "SampledData.data",
                    Id = "SampledData.data",
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
        }
    }
}
