using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'MedicinalProductManufactured'
    /// </summary>
    // 0. MedicinalProductManufactured
    public class MedicinalProductManufactured : FhirKhit.Maker.Common.Resource.ResourceBase                                                 // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class MedicinalProductManufactured_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 1. MedicinalProductManufactured.manufacturedDoseForm
            public ElementDefinitionInfo ManufacturedDoseForm;                                                                              // MakerGen.cs:211
            // 2. MedicinalProductManufactured.unitOfPresentation
            public ElementDefinitionInfo UnitOfPresentation;                                                                                // MakerGen.cs:211
            // 3. MedicinalProductManufactured.quantity
            public ElementDefinitionInfo Quantity;                                                                                          // MakerGen.cs:211
            // 4. MedicinalProductManufactured.manufacturer
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:211
            // 5. MedicinalProductManufactured.ingredient
            public ElementDefinitionInfo Ingredient;                                                                                        // MakerGen.cs:211
            // 6. MedicinalProductManufactured.physicalCharacteristics
            public ElementDefinitionInfo PhysicalCharacteristics;                                                                           // MakerGen.cs:211
            // 7. MedicinalProductManufactured.otherCharacteristics
            public ElementDefinitionInfo OtherCharacteristics;                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public MedicinalProductManufactured_Elements()                                                                                  // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. MedicinalProductManufactured.manufacturedDoseForm
                    this.ManufacturedDoseForm = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ManufacturedDoseForm",                                                                                      // MakerGen.cs:230
                        Path= "MedicinalProductManufactured.manufacturedDoseForm",                                                          // MakerGen.cs:231
                        Id = "MedicinalProductManufactured.manufacturedDoseForm",                                                           // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. MedicinalProductManufactured.unitOfPresentation
                    this.UnitOfPresentation = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "UnitOfPresentation",                                                                                        // MakerGen.cs:230
                        Path= "MedicinalProductManufactured.unitOfPresentation",                                                            // MakerGen.cs:231
                        Id = "MedicinalProductManufactured.unitOfPresentation",                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. MedicinalProductManufactured.quantity
                    this.Quantity = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Quantity",                                                                                                  // MakerGen.cs:230
                        Path= "MedicinalProductManufactured.quantity",                                                                      // MakerGen.cs:231
                        Id = "MedicinalProductManufactured.quantity",                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. MedicinalProductManufactured.manufacturer
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:230
                        Path= "MedicinalProductManufactured.manufacturer",                                                                  // MakerGen.cs:231
                        Id = "MedicinalProductManufactured.manufacturer",                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. MedicinalProductManufactured.ingredient
                    this.Ingredient = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Ingredient",                                                                                                // MakerGen.cs:230
                        Path= "MedicinalProductManufactured.ingredient",                                                                    // MakerGen.cs:231
                        Id = "MedicinalProductManufactured.ingredient",                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"                                    // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. MedicinalProductManufactured.physicalCharacteristics
                    this.PhysicalCharacteristics = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PhysicalCharacteristics",                                                                                   // MakerGen.cs:230
                        Path= "MedicinalProductManufactured.physicalCharacteristics",                                                       // MakerGen.cs:231
                        Id = "MedicinalProductManufactured.physicalCharacteristics",                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ProdCharacteristic                                                            // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. MedicinalProductManufactured.otherCharacteristics
                    this.OtherCharacteristics = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "OtherCharacteristics",                                                                                      // MakerGen.cs:230
                        Path= "MedicinalProductManufactured.otherCharacteristics",                                                          // MakerGen.cs:231
                        Id = "MedicinalProductManufactured.otherCharacteristics",                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                ManufacturedDoseForm.Write(sDef);                                                                                           // MakerGen.cs:215
                UnitOfPresentation.Write(sDef);                                                                                             // MakerGen.cs:215
                Quantity.Write(sDef);                                                                                                       // MakerGen.cs:215
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:215
                Ingredient.Write(sDef);                                                                                                     // MakerGen.cs:215
                PhysicalCharacteristics.Write(sDef);                                                                                        // MakerGen.cs:215
                OtherCharacteristics.Write(sDef);                                                                                           // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public MedicinalProductManufactured_Elements Elements                                                                               // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new MedicinalProductManufactured_Elements();                                                            // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        MedicinalProductManufactured_Elements elements;                                                                                     // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public MedicinalProductManufactured()                                                                                               // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "MedicinalProductManufactured";                                                                                     // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured";                                              // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "MedicinalProductManufactured",                                                                                      // MakerGen.cs:423
                ElementId = "MedicinalProductManufactured"                                                                                  // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
