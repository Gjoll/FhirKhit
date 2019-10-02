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
      "id": "MedicinalProductManufactured",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured",
      "version": "4.0.0",
      "name": "MedicinalProductManufactured",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "The manufactured item as contained in the packaged medicinal product.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductManufactured",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductManufactured",
            "path": "MedicinalProductManufactured",
            "short": "The manufactured item as contained in the packaged medicinal product",
            "definition": "The manufactured item as contained in the packaged medicinal product.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductManufactured.manufacturedDoseForm",
            "path": "MedicinalProductManufactured.manufacturedDoseForm",
            "short": "Dose form as manufactured and before any transformation into the pharmaceutical product",
            "definition": "Dose form as manufactured and before any transformation into the pharmaceutical product.",
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
            "id": "MedicinalProductManufactured.unitOfPresentation",
            "path": "MedicinalProductManufactured.unitOfPresentation",
            "short": "The “real world” units in which the quantity of the manufactured item is described",
            "definition": "The “real world” units in which the quantity of the manufactured item is described.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductManufactured.quantity",
            "path": "MedicinalProductManufactured.quantity",
            "short": "The quantity or \"count number\" of the manufactured item",
            "definition": "The quantity or \"count number\" of the manufactured item.",
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
            "id": "MedicinalProductManufactured.manufacturer",
            "path": "MedicinalProductManufactured.manufacturer",
            "short": "Manufacturer of the item (Note that this should be named \"manufacturer\" but it currently causes technical issues)",
            "definition": "Manufacturer of the item (Note that this should be named \"manufacturer\" but it currently causes technical issues).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductManufactured.ingredient",
            "path": "MedicinalProductManufactured.ingredient",
            "short": "Ingredient",
            "definition": "Ingredient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductManufactured.physicalCharacteristics",
            "path": "MedicinalProductManufactured.physicalCharacteristics",
            "short": "Dimensions, color etc.",
            "definition": "Dimensions, color etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "ProdCharacteristic"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductManufactured.otherCharacteristics",
            "path": "MedicinalProductManufactured.otherCharacteristics",
            "short": "Other codeable characteristics",
            "definition": "Other codeable characteristics.",
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
    /// Fhir resource 'MedicinalProductManufactured'
    /// </summary>
    // 0. MedicinalProductManufactured
    public partial class Resource_MedicinalProductManufactured : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. MedicinalProductManufactured.manufacturedDoseForm
        public ElementDefinitionInfo Element_ManufacturedDoseForm;
        // 2. MedicinalProductManufactured.unitOfPresentation
        public ElementDefinitionInfo Element_UnitOfPresentation;
        // 3. MedicinalProductManufactured.quantity
        public ElementDefinitionInfo Element_Quantity;
        // 4. MedicinalProductManufactured.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;
        // 5. MedicinalProductManufactured.ingredient
        public ElementDefinitionInfo Element_Ingredient;
        // 6. MedicinalProductManufactured.physicalCharacteristics
        public ElementDefinitionInfo Element_PhysicalCharacteristics;
        // 7. MedicinalProductManufactured.otherCharacteristics
        public ElementDefinitionInfo Element_OtherCharacteristics;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductManufactured",
                ElementId = "MedicinalProductManufactured"
            });
            Element_ManufacturedDoseForm.Write(sDef);
            Element_UnitOfPresentation.Write(sDef);
            Element_Quantity.Write(sDef);
            Element_Manufacturer.Write(sDef);
            Element_Ingredient.Write(sDef);
            Element_PhysicalCharacteristics.Write(sDef);
            Element_OtherCharacteristics.Write(sDef);
        }
        
        public Resource_MedicinalProductManufactured()
        {
            {
                // 1. MedicinalProductManufactured.manufacturedDoseForm
                this.Element_ManufacturedDoseForm = new ElementDefinitionInfo
                {
                    Name = "Element_ManufacturedDoseForm",
                    Path= "MedicinalProductManufactured.manufacturedDoseForm",
                    Id = "MedicinalProductManufactured.manufacturedDoseForm",
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
                // 2. MedicinalProductManufactured.unitOfPresentation
                this.Element_UnitOfPresentation = new ElementDefinitionInfo
                {
                    Name = "Element_UnitOfPresentation",
                    Path= "MedicinalProductManufactured.unitOfPresentation",
                    Id = "MedicinalProductManufactured.unitOfPresentation",
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
                // 3. MedicinalProductManufactured.quantity
                this.Element_Quantity = new ElementDefinitionInfo
                {
                    Name = "Element_Quantity",
                    Path= "MedicinalProductManufactured.quantity",
                    Id = "MedicinalProductManufactured.quantity",
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
                // 4. MedicinalProductManufactured.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo
                {
                    Name = "Element_Manufacturer",
                    Path= "MedicinalProductManufactured.manufacturer",
                    Id = "MedicinalProductManufactured.manufacturer",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 5. MedicinalProductManufactured.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo
                {
                    Name = "Element_Ingredient",
                    Path= "MedicinalProductManufactured.ingredient",
                    Id = "MedicinalProductManufactured.ingredient",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"
                            }
                        }
                    }
                };
            }
            {
                // 6. MedicinalProductManufactured.physicalCharacteristics
                this.Element_PhysicalCharacteristics = new ElementDefinitionInfo
                {
                    Name = "Element_PhysicalCharacteristics",
                    Path= "MedicinalProductManufactured.physicalCharacteristics",
                    Id = "MedicinalProductManufactured.physicalCharacteristics",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ProdCharacteristic
                        {
                        }
                    }
                };
            }
            {
                // 7. MedicinalProductManufactured.otherCharacteristics
                this.Element_OtherCharacteristics = new ElementDefinitionInfo
                {
                    Name = "Element_OtherCharacteristics",
                    Path= "MedicinalProductManufactured.otherCharacteristics",
                    Id = "MedicinalProductManufactured.otherCharacteristics",
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
            this.Name = "MedicinalProductManufactured";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured";
        }
    }
}
