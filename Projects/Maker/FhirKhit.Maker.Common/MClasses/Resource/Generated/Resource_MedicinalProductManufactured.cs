using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MedicinalProductManufactured'
    /// </summary>
    // 0. MedicinalProductManufactured
    public class Resource_MedicinalProductManufactured : FhirKhit.Maker.Common.Resource.Resource_DomainResource                             // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. MedicinalProductManufactured.manufacturedDoseForm
        public ElementDefinitionInfo Element_ManufacturedDoseForm;                                                                          // MakerGen.cs:219
        // 2. MedicinalProductManufactured.unitOfPresentation
        public ElementDefinitionInfo Element_UnitOfPresentation;                                                                            // MakerGen.cs:219
        // 3. MedicinalProductManufactured.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:219
        // 4. MedicinalProductManufactured.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;                                                                                  // MakerGen.cs:219
        // 5. MedicinalProductManufactured.ingredient
        public ElementDefinitionInfo Element_Ingredient;                                                                                    // MakerGen.cs:219
        // 6. MedicinalProductManufactured.physicalCharacteristics
        public ElementDefinitionInfo Element_PhysicalCharacteristics;                                                                       // MakerGen.cs:219
        // 7. MedicinalProductManufactured.otherCharacteristics
        public ElementDefinitionInfo Element_OtherCharacteristics;                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MedicinalProductManufactured",                                                                                      // MakerGen.cs:395
                ElementId = "MedicinalProductManufactured"                                                                                  // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_ManufacturedDoseForm.Write(sDef);                                                                                       // MakerGen.cs:223
            Element_UnitOfPresentation.Write(sDef);                                                                                         // MakerGen.cs:223
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Manufacturer.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Ingredient.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_PhysicalCharacteristics.Write(sDef);                                                                                    // MakerGen.cs:223
            Element_OtherCharacteristics.Write(sDef);                                                                                       // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MedicinalProductManufactured()                                                                                      // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MedicinalProductManufactured.manufacturedDoseForm
                this.Element_ManufacturedDoseForm = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ManufacturedDoseForm",                                                                                  // MakerGen.cs:238
                    Path= "MedicinalProductManufactured.manufacturedDoseForm",                                                              // MakerGen.cs:239
                    Id = "MedicinalProductManufactured.manufacturedDoseForm",                                                               // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. MedicinalProductManufactured.unitOfPresentation
                this.Element_UnitOfPresentation = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_UnitOfPresentation",                                                                                    // MakerGen.cs:238
                    Path= "MedicinalProductManufactured.unitOfPresentation",                                                                // MakerGen.cs:239
                    Id = "MedicinalProductManufactured.unitOfPresentation",                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. MedicinalProductManufactured.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:238
                    Path= "MedicinalProductManufactured.quantity",                                                                          // MakerGen.cs:239
                    Id = "MedicinalProductManufactured.quantity",                                                                           // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. MedicinalProductManufactured.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:238
                    Path= "MedicinalProductManufactured.manufacturer",                                                                      // MakerGen.cs:239
                    Id = "MedicinalProductManufactured.manufacturer",                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. MedicinalProductManufactured.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Ingredient",                                                                                            // MakerGen.cs:238
                    Path= "MedicinalProductManufactured.ingredient",                                                                        // MakerGen.cs:239
                    Id = "MedicinalProductManufactured.ingredient",                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"                                        // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. MedicinalProductManufactured.physicalCharacteristics
                this.Element_PhysicalCharacteristics = new ElementDefinitionInfo                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PhysicalCharacteristics",                                                                               // MakerGen.cs:238
                    Path= "MedicinalProductManufactured.physicalCharacteristics",                                                           // MakerGen.cs:239
                    Id = "MedicinalProductManufactured.physicalCharacteristics",                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ProdCharacteristic                                                           // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. MedicinalProductManufactured.otherCharacteristics
                this.Element_OtherCharacteristics = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_OtherCharacteristics",                                                                                  // MakerGen.cs:238
                    Path= "MedicinalProductManufactured.otherCharacteristics",                                                              // MakerGen.cs:239
                    Id = "MedicinalProductManufactured.otherCharacteristics",                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MedicinalProductManufactured";                                                                                     // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured";                                              // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
