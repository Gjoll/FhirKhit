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
      "id": "ProductShelfLife",
      "url": "http://hl7.org/fhir/StructureDefinition/ProductShelfLife",
      "version": "4.0.0",
      "name": "ProductShelfLife",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for ProductShelfLife Type: The shelf-life and storage information for a medicinal product item or container can be described using this class.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "ProductShelfLife",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ProductShelfLife",
            "path": "ProductShelfLife",
            "short": "The shelf-life and storage information for a medicinal product item or container can be described using this class",
            "definition": "The shelf-life and storage information for a medicinal product item or container can be described using this class.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ProductShelfLife.identifier",
            "path": "ProductShelfLife.identifier",
            "short": "Unique identifier for the packaged Medicinal Product",
            "definition": "Unique identifier for the packaged Medicinal Product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProductShelfLife.type",
            "path": "ProductShelfLife.type",
            "short": "This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified",
            "definition": "This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProductShelfLife.period",
            "path": "ProductShelfLife.period",
            "short": "The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
            "definition": "The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ProductShelfLife.specialPrecautionsForStorage",
            "path": "ProductShelfLife.specialPrecautionsForStorage",
            "short": "Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified",
            "definition": "Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
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
    /// Fhir complex 'ProductShelfLife'
    /// </summary>
    // 0. ProductShelfLife
    public class Type_ProductShelfLife : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. ProductShelfLife.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ProductShelfLife.type
        public ElementDefinitionInfo Element_Type;
        // 3. ProductShelfLife.period
        public ElementDefinitionInfo Element_Period;
        // 4. ProductShelfLife.specialPrecautionsForStorage
        public ElementDefinitionInfo Element_SpecialPrecautionsForStorage;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ProductShelfLife",
                ElementId = "ProductShelfLife"
            });
            Element_Identifier.Write(sDef);
            Element_Type.Write(sDef);
            Element_Period.Write(sDef);
            Element_SpecialPrecautionsForStorage.Write(sDef);
        }
        
        public Type_ProductShelfLife()
        {
            {
                // 1. ProductShelfLife.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ProductShelfLife.identifier",
                    Id = "ProductShelfLife.identifier",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. ProductShelfLife.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "ProductShelfLife.type",
                    Id = "ProductShelfLife.type",
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
                // 3. ProductShelfLife.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "ProductShelfLife.period",
                    Id = "ProductShelfLife.period",
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
                // 4. ProductShelfLife.specialPrecautionsForStorage
                this.Element_SpecialPrecautionsForStorage = new ElementDefinitionInfo
                {
                    Name = "Element_SpecialPrecautionsForStorage",
                    Path= "ProductShelfLife.specialPrecautionsForStorage",
                    Id = "ProductShelfLife.specialPrecautionsForStorage",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
        }
    }
}
