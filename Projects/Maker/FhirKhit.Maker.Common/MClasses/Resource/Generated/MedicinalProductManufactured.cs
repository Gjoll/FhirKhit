using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'MedicinalProductManufactured'
    /// </summary>
    // 0. MedicinalProductManufactured
    public class MedicinalProductManufactured : FhirKhit.Maker.Common.Resource.ResourceBase                                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class MedicinalProductManufactured_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. MedicinalProductManufactured.manufacturedDoseForm
            public ElementDefinitionInfo ManufacturedDoseForm;                                                                              // MakerGen.cs:216
            // 2. MedicinalProductManufactured.unitOfPresentation
            public ElementDefinitionInfo UnitOfPresentation;                                                                                // MakerGen.cs:216
            // 3. MedicinalProductManufactured.quantity
            public ElementDefinitionInfo Quantity;                                                                                          // MakerGen.cs:216
            // 4. MedicinalProductManufactured.manufacturer
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:216
            // 5. MedicinalProductManufactured.ingredient
            public ElementDefinitionInfo Ingredient;                                                                                        // MakerGen.cs:216
            // 6. MedicinalProductManufactured.physicalCharacteristics
            public ElementDefinitionInfo PhysicalCharacteristics;                                                                           // MakerGen.cs:216
            // 7. MedicinalProductManufactured.otherCharacteristics
            public ElementDefinitionInfo OtherCharacteristics;                                                                              // MakerGen.cs:216
            public MedicinalProductManufactured_Elements()                                                                                  // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicinalProductManufactured.manufacturedDoseForm
                    this.ManufacturedDoseForm = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ManufacturedDoseForm",                                                                                      // MakerGen.cs:235
                        Path= "MedicinalProductManufactured.manufacturedDoseForm",                                                          // MakerGen.cs:236
                        Id = "MedicinalProductManufactured.manufacturedDoseForm",                                                           // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MedicinalProductManufactured.unitOfPresentation
                    this.UnitOfPresentation = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UnitOfPresentation",                                                                                        // MakerGen.cs:235
                        Path= "MedicinalProductManufactured.unitOfPresentation",                                                            // MakerGen.cs:236
                        Id = "MedicinalProductManufactured.unitOfPresentation",                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. MedicinalProductManufactured.quantity
                    this.Quantity = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Quantity",                                                                                                  // MakerGen.cs:235
                        Path= "MedicinalProductManufactured.quantity",                                                                      // MakerGen.cs:236
                        Id = "MedicinalProductManufactured.quantity",                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. MedicinalProductManufactured.manufacturer
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:235
                        Path= "MedicinalProductManufactured.manufacturer",                                                                  // MakerGen.cs:236
                        Id = "MedicinalProductManufactured.manufacturer",                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. MedicinalProductManufactured.ingredient
                    this.Ingredient = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Ingredient",                                                                                                // MakerGen.cs:235
                        Path= "MedicinalProductManufactured.ingredient",                                                                    // MakerGen.cs:236
                        Id = "MedicinalProductManufactured.ingredient",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. MedicinalProductManufactured.physicalCharacteristics
                    this.PhysicalCharacteristics = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PhysicalCharacteristics",                                                                                   // MakerGen.cs:235
                        Path= "MedicinalProductManufactured.physicalCharacteristics",                                                       // MakerGen.cs:236
                        Id = "MedicinalProductManufactured.physicalCharacteristics",                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ProdCharacteristic                                                            // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. MedicinalProductManufactured.otherCharacteristics
                    this.OtherCharacteristics = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OtherCharacteristics",                                                                                      // MakerGen.cs:235
                        Path= "MedicinalProductManufactured.otherCharacteristics",                                                          // MakerGen.cs:236
                        Id = "MedicinalProductManufactured.otherCharacteristics",                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                ManufacturedDoseForm.Write(sDef);                                                                                           // MakerGen.cs:220
                UnitOfPresentation.Write(sDef);                                                                                             // MakerGen.cs:220
                Quantity.Write(sDef);                                                                                                       // MakerGen.cs:220
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:220
                Ingredient.Write(sDef);                                                                                                     // MakerGen.cs:220
                PhysicalCharacteristics.Write(sDef);                                                                                        // MakerGen.cs:220
                OtherCharacteristics.Write(sDef);                                                                                           // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public MedicinalProductManufactured_Elements Elements { get; }                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public MedicinalProductManufactured()                                                                                               // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new MedicinalProductManufactured_Elements();                                                                    // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
