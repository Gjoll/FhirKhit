using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'MedicinalProductManufactured'
    /// </summary>
    // 0. MedicinalProductManufactured
    public class Resource_MedicinalProductManufactured : FhirKhit.Maker.Common.Resource.ResourceBase                                        // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. MedicinalProductManufactured.manufacturedDoseForm
        public ElementDefinitionInfo Element_ManufacturedDoseForm;                                                                          // MakerGen.cs:212
        // 2. MedicinalProductManufactured.unitOfPresentation
        public ElementDefinitionInfo Element_UnitOfPresentation;                                                                            // MakerGen.cs:212
        // 3. MedicinalProductManufactured.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:212
        // 4. MedicinalProductManufactured.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;                                                                                  // MakerGen.cs:212
        // 5. MedicinalProductManufactured.ingredient
        public ElementDefinitionInfo Element_Ingredient;                                                                                    // MakerGen.cs:212
        // 6. MedicinalProductManufactured.physicalCharacteristics
        public ElementDefinitionInfo Element_PhysicalCharacteristics;                                                                       // MakerGen.cs:212
        // 7. MedicinalProductManufactured.otherCharacteristics
        public ElementDefinitionInfo Element_OtherCharacteristics;                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "MedicinalProductManufactured",                                                                                      // MakerGen.cs:388
                ElementId = "MedicinalProductManufactured"                                                                                  // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_ManufacturedDoseForm.Write(sDef);                                                                                       // MakerGen.cs:216
            Element_UnitOfPresentation.Write(sDef);                                                                                         // MakerGen.cs:216
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Manufacturer.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Ingredient.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_PhysicalCharacteristics.Write(sDef);                                                                                    // MakerGen.cs:216
            Element_OtherCharacteristics.Write(sDef);                                                                                       // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_MedicinalProductManufactured()                                                                                      // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. MedicinalProductManufactured.manufacturedDoseForm
                this.Element_ManufacturedDoseForm = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ManufacturedDoseForm",                                                                                  // MakerGen.cs:231
                    Path= "MedicinalProductManufactured.manufacturedDoseForm",                                                              // MakerGen.cs:232
                    Id = "MedicinalProductManufactured.manufacturedDoseForm",                                                               // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. MedicinalProductManufactured.unitOfPresentation
                this.Element_UnitOfPresentation = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_UnitOfPresentation",                                                                                    // MakerGen.cs:231
                    Path= "MedicinalProductManufactured.unitOfPresentation",                                                                // MakerGen.cs:232
                    Id = "MedicinalProductManufactured.unitOfPresentation",                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. MedicinalProductManufactured.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:231
                    Path= "MedicinalProductManufactured.quantity",                                                                          // MakerGen.cs:232
                    Id = "MedicinalProductManufactured.quantity",                                                                           // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. MedicinalProductManufactured.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:231
                    Path= "MedicinalProductManufactured.manufacturer",                                                                      // MakerGen.cs:232
                    Id = "MedicinalProductManufactured.manufacturer",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. MedicinalProductManufactured.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Ingredient",                                                                                            // MakerGen.cs:231
                    Path= "MedicinalProductManufactured.ingredient",                                                                        // MakerGen.cs:232
                    Id = "MedicinalProductManufactured.ingredient",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"                                        // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. MedicinalProductManufactured.physicalCharacteristics
                this.Element_PhysicalCharacteristics = new ElementDefinitionInfo                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PhysicalCharacteristics",                                                                               // MakerGen.cs:231
                    Path= "MedicinalProductManufactured.physicalCharacteristics",                                                           // MakerGen.cs:232
                    Id = "MedicinalProductManufactured.physicalCharacteristics",                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ProdCharacteristic                                                           // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. MedicinalProductManufactured.otherCharacteristics
                this.Element_OtherCharacteristics = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_OtherCharacteristics",                                                                                  // MakerGen.cs:231
                    Path= "MedicinalProductManufactured.otherCharacteristics",                                                              // MakerGen.cs:232
                    Id = "MedicinalProductManufactured.otherCharacteristics",                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "MedicinalProductManufactured";                                                                                     // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured";                                              // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
