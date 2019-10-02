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
      "id": "Range",
      "url": "http://hl7.org/fhir/StructureDefinition/Range",
      "version": "4.0.0",
      "name": "Range",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Range Type: A set of ordered Quantities defined by a low and high limit.",
      "purpose": "Need to be able to specify ranges of values.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Range",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Range",
            "path": "Range",
            "short": "Set of values bounded by low and high",
            "definition": "A set of ordered Quantities defined by a low and high limit.",
            "comment": "The stated low and high value are assumed to have arbitrarily high precision when it comes to determining which values are in the range. I.e. 1.99 is not in the range 2 -> 3.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Range.low",
            "path": "Range.low",
            "short": "Low limit",
            "definition": "The low limit. The boundary is inclusive.",
            "comment": "If the low element is missing, the low boundary is not known.",
            "min": 0,
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
            "id": "Range.high",
            "path": "Range.high",
            "short": "High limit",
            "definition": "The high limit. The boundary is inclusive.",
            "comment": "If the high element is missing, the high boundary is not known.",
            "min": 0,
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
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir complex 'Range'
    /// </summary>
    // 0. Range
    public partial class Type_Range : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. Range.low
        public ElementDefinitionInfo Element_Low;
        // 2. Range.high
        public ElementDefinitionInfo Element_High;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Range",
                ElementId = "Range"
            });
            Element_Low.Write(sDef);
            Element_High.Write(sDef);
        }
        
        public Type_Range()
        {
            {
                // 1. Range.low
                this.Element_Low = new ElementDefinitionInfo
                {
                    Name = "Element_Low",
                    Path= "Range.low",
                    Id = "Range.low",
                    Min = 0,
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
                // 2. Range.high
                this.Element_High = new ElementDefinitionInfo
                {
                    Name = "Element_High",
                    Path= "Range.high",
                    Id = "Range.high",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
        }
    }
}
