using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
    {
      "resourceType": "StructureDefinition",
      "id": "MedicinalProductPackaged",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged",
      "version": "4.0.0",
      "name": "MedicinalProductPackaged",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "A medicinal product in a container or package.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductPackaged",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductPackaged",
            "path": "MedicinalProductPackaged",
            "short": "A medicinal product in a container or package",
            "definition": "A medicinal product in a container or package.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductPackaged.identifier",
            "path": "MedicinalProductPackaged.identifier",
            "short": "Unique identifier",
            "definition": "Unique identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.subject",
            "path": "MedicinalProductPackaged.subject",
            "short": "The product with this is a pack for",
            "definition": "The product with this is a pack for.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.description",
            "path": "MedicinalProductPackaged.description",
            "short": "Textual description",
            "definition": "Textual description.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.legalStatusOfSupply",
            "path": "MedicinalProductPackaged.legalStatusOfSupply",
            "short": "The legal status of supply of the medicinal product as classified by the regulator",
            "definition": "The legal status of supply of the medicinal product as classified by the regulator.",
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
            "id": "MedicinalProductPackaged.marketingStatus",
            "path": "MedicinalProductPackaged.marketingStatus",
            "short": "Marketing information",
            "definition": "Marketing information.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "MarketingStatus"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.marketingAuthorization",
            "path": "MedicinalProductPackaged.marketingAuthorization",
            "short": "Manufacturer of this Package Item",
            "definition": "Manufacturer of this Package Item.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.manufacturer",
            "path": "MedicinalProductPackaged.manufacturer",
            "short": "Manufacturer of this Package Item",
            "definition": "Manufacturer of this Package Item.",
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
            "id": "MedicinalProductPackaged.batchIdentifier",
            "path": "MedicinalProductPackaged.batchIdentifier",
            "short": "Batch numbering",
            "definition": "Batch numbering.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.batchIdentifier.outerPackaging",
            "path": "MedicinalProductPackaged.batchIdentifier.outerPackaging",
            "short": "A number appearing on the outer packaging of a specific batch",
            "definition": "A number appearing on the outer packaging of a specific batch.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.batchIdentifier.immediatePackaging",
            "path": "MedicinalProductPackaged.batchIdentifier.immediatePackaging",
            "short": "A number appearing on the immediate packaging (and not the outer packaging)",
            "definition": "A number appearing on the immediate packaging (and not the outer packaging).",
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
            "id": "MedicinalProductPackaged.packageItem",
            "path": "MedicinalProductPackaged.packageItem",
            "short": "A packaging item, as a contained for medicine, possibly with other packaging items within",
            "definition": "A packaging item, as a contained for medicine, possibly with other packaging items within.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.packageItem.identifier",
            "path": "MedicinalProductPackaged.packageItem.identifier",
            "short": "Including possibly Data Carrier Identifier",
            "definition": "Including possibly Data Carrier Identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.packageItem.type",
            "path": "MedicinalProductPackaged.packageItem.type",
            "short": "The physical type of the container of the medicine",
            "definition": "The physical type of the container of the medicine.",
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
            "id": "MedicinalProductPackaged.packageItem.quantity",
            "path": "MedicinalProductPackaged.packageItem.quantity",
            "short": "The quantity of this package in the medicinal product, at the current level of packaging. The outermost is always 1",
            "definition": "The quantity of this package in the medicinal product, at the current level of packaging. The outermost is always 1.",
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
            "id": "MedicinalProductPackaged.packageItem.material",
            "path": "MedicinalProductPackaged.packageItem.material",
            "short": "Material type of the package item",
            "definition": "Material type of the package item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.packageItem.alternateMaterial",
            "path": "MedicinalProductPackaged.packageItem.alternateMaterial",
            "short": "A possible alternate material for the packaging",
            "definition": "A possible alternate material for the packaging.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.packageItem.device",
            "path": "MedicinalProductPackaged.packageItem.device",
            "short": "A device accompanying a medicinal product",
            "definition": "A device accompanying a medicinal product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.packageItem.manufacturedItem",
            "path": "MedicinalProductPackaged.packageItem.manufacturedItem",
            "short": "The manufactured item as contained in the packaged medicinal product",
            "definition": "The manufactured item as contained in the packaged medicinal product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.packageItem.packageItem",
            "path": "MedicinalProductPackaged.packageItem.packageItem",
            "short": "Allows containers within containers",
            "definition": "Allows containers within containers.",
            "min": 0,
            "max": "*",
            "contentReference": "#MedicinalProductPackaged.packageItem",
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.packageItem.physicalCharacteristics",
            "path": "MedicinalProductPackaged.packageItem.physicalCharacteristics",
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
            "id": "MedicinalProductPackaged.packageItem.otherCharacteristics",
            "path": "MedicinalProductPackaged.packageItem.otherCharacteristics",
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
          },
          {
            "id": "MedicinalProductPackaged.packageItem.shelfLifeStorage",
            "path": "MedicinalProductPackaged.packageItem.shelfLifeStorage",
            "short": "Shelf Life and storage information",
            "definition": "Shelf Life and storage information.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ProductShelfLife"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPackaged.packageItem.manufacturer",
            "path": "MedicinalProductPackaged.packageItem.manufacturer",
            "short": "Manufacturer of this Package Item",
            "definition": "Manufacturer of this Package Item.",
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
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'MedicinalProductPackaged'
    /// </summary>
    // 0. MedicinalProductPackaged
    public class MedicinalProductPackaged : FhirKhit.Maker.Common.Resource.ResourceBase                                                     // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class MedicinalProductPackaged_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 8. MedicinalProductPackaged.batchIdentifier
            public class Type_BatchIdentifier : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_BatchIdentifier_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 9. MedicinalProductPackaged.batchIdentifier.outerPackaging
                    public ElementDefinitionInfo OuterPackaging;                                                                            // MakerGen.cs:236
                    // 10. MedicinalProductPackaged.batchIdentifier.immediatePackaging
                    public ElementDefinitionInfo ImmediatePackaging;                                                                        // MakerGen.cs:236
                    public Type_BatchIdentifier_Elements()                                                                                  // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. MedicinalProductPackaged.batchIdentifier.outerPackaging
                            this.OuterPackaging = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "OuterPackaging",                                                                                    // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.batchIdentifier.outerPackaging",                                            // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.batchIdentifier.outerPackaging",                                             // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 10. MedicinalProductPackaged.batchIdentifier.immediatePackaging
                            this.ImmediatePackaging = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ImmediatePackaging",                                                                                // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.batchIdentifier.immediatePackaging",                                        // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.batchIdentifier.immediatePackaging",                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        OuterPackaging.Write(sDef);                                                                                         // MakerGen.cs:240
                        ImmediatePackaging.Write(sDef);                                                                                     // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_BatchIdentifier_Elements Elements { get; }                                                                      // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_BatchIdentifier()                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_BatchIdentifier_Elements();                                                                    // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 11. MedicinalProductPackaged.packageItem
            public class Type_PackageItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_PackageItem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 12. MedicinalProductPackaged.packageItem.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:236
                    // 13. MedicinalProductPackaged.packageItem.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 14. MedicinalProductPackaged.packageItem.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:236
                    // 15. MedicinalProductPackaged.packageItem.material
                    public ElementDefinitionInfo Material;                                                                                  // MakerGen.cs:236
                    // 16. MedicinalProductPackaged.packageItem.alternateMaterial
                    public ElementDefinitionInfo AlternateMaterial;                                                                         // MakerGen.cs:236
                    // 17. MedicinalProductPackaged.packageItem.device
                    public ElementDefinitionInfo Device;                                                                                    // MakerGen.cs:236
                    // 18. MedicinalProductPackaged.packageItem.manufacturedItem
                    public ElementDefinitionInfo ManufacturedItem;                                                                          // MakerGen.cs:236
                    // 19. MedicinalProductPackaged.packageItem.packageItem
                    public ElementDefinitionInfo PackageItem;                                                                               // MakerGen.cs:236
                    // 20. MedicinalProductPackaged.packageItem.physicalCharacteristics
                    public ElementDefinitionInfo PhysicalCharacteristics;                                                                   // MakerGen.cs:236
                    // 21. MedicinalProductPackaged.packageItem.otherCharacteristics
                    public ElementDefinitionInfo OtherCharacteristics;                                                                      // MakerGen.cs:236
                    // 22. MedicinalProductPackaged.packageItem.shelfLifeStorage
                    public ElementDefinitionInfo ShelfLifeStorage;                                                                          // MakerGen.cs:236
                    // 23. MedicinalProductPackaged.packageItem.manufacturer
                    public ElementDefinitionInfo Manufacturer;                                                                              // MakerGen.cs:236
                    public Type_PackageItem_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 12. MedicinalProductPackaged.packageItem.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Identifier",                                                                                        // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.identifier",                                                    // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.identifier",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. MedicinalProductPackaged.packageItem.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.type",                                                          // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.type",                                                           // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. MedicinalProductPackaged.packageItem.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Quantity",                                                                                          // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.quantity",                                                      // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.quantity",                                                       // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 15. MedicinalProductPackaged.packageItem.material
                            this.Material = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Material",                                                                                          // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.material",                                                      // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.material",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. MedicinalProductPackaged.packageItem.alternateMaterial
                            this.AlternateMaterial = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "AlternateMaterial",                                                                                 // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.alternateMaterial",                                             // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.alternateMaterial",                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. MedicinalProductPackaged.packageItem.device
                            this.Device = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Device",                                                                                            // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.device",                                                        // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.device",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                      // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. MedicinalProductPackaged.packageItem.manufacturedItem
                            this.ManufacturedItem = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ManufacturedItem",                                                                                  // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.manufacturedItem",                                              // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.manufacturedItem",                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured"                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. MedicinalProductPackaged.packageItem.packageItem
                            this.PackageItem = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "PackageItem",                                                                                       // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.packageItem",                                                   // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.packageItem",                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 20. MedicinalProductPackaged.packageItem.physicalCharacteristics
                            this.PhysicalCharacteristics = new ElementDefinitionInfo                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "PhysicalCharacteristics",                                                                           // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.physicalCharacteristics",                                       // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.physicalCharacteristics",                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.ProdCharacteristic                                                    // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 21. MedicinalProductPackaged.packageItem.otherCharacteristics
                            this.OtherCharacteristics = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "OtherCharacteristics",                                                                              // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.otherCharacteristics",                                          // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.otherCharacteristics",                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 22. MedicinalProductPackaged.packageItem.shelfLifeStorage
                            this.ShelfLifeStorage = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ShelfLifeStorage",                                                                                  // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.shelfLifeStorage",                                              // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.shelfLifeStorage",                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.ProductShelfLife                                                      // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 23. MedicinalProductPackaged.packageItem.manufacturer
                            this.Manufacturer = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Manufacturer",                                                                                      // MakerGen.cs:255
                                Path= "MedicinalProductPackaged.packageItem.manufacturer",                                                  // MakerGen.cs:256
                                Id = "MedicinalProductPackaged.packageItem.manufacturer",                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:240
                        Material.Write(sDef);                                                                                               // MakerGen.cs:240
                        AlternateMaterial.Write(sDef);                                                                                      // MakerGen.cs:240
                        Device.Write(sDef);                                                                                                 // MakerGen.cs:240
                        ManufacturedItem.Write(sDef);                                                                                       // MakerGen.cs:240
                        PackageItem.Write(sDef);                                                                                            // MakerGen.cs:240
                        PhysicalCharacteristics.Write(sDef);                                                                                // MakerGen.cs:240
                        OtherCharacteristics.Write(sDef);                                                                                   // MakerGen.cs:240
                        ShelfLifeStorage.Write(sDef);                                                                                       // MakerGen.cs:240
                        Manufacturer.Write(sDef);                                                                                           // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_PackageItem_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_PackageItem()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_PackageItem_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. MedicinalProductPackaged.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. MedicinalProductPackaged.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 3. MedicinalProductPackaged.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:236
            // 4. MedicinalProductPackaged.legalStatusOfSupply
            public ElementDefinitionInfo LegalStatusOfSupply;                                                                               // MakerGen.cs:236
            // 5. MedicinalProductPackaged.marketingStatus
            public ElementDefinitionInfo MarketingStatus;                                                                                   // MakerGen.cs:236
            // 6. MedicinalProductPackaged.marketingAuthorization
            public ElementDefinitionInfo MarketingAuthorization;                                                                            // MakerGen.cs:236
            // 7. MedicinalProductPackaged.manufacturer
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:236
            public MedicinalProductPackaged_Elements()                                                                                      // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. MedicinalProductPackaged.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "MedicinalProductPackaged.identifier",                                                                        // MakerGen.cs:256
                        Id = "MedicinalProductPackaged.identifier",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. MedicinalProductPackaged.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "MedicinalProductPackaged.subject",                                                                           // MakerGen.cs:256
                        Id = "MedicinalProductPackaged.subject",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct"                                              // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. MedicinalProductPackaged.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Description",                                                                                               // MakerGen.cs:255
                        Path= "MedicinalProductPackaged.description",                                                                       // MakerGen.cs:256
                        Id = "MedicinalProductPackaged.description",                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. MedicinalProductPackaged.legalStatusOfSupply
                    this.LegalStatusOfSupply = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "LegalStatusOfSupply",                                                                                       // MakerGen.cs:255
                        Path= "MedicinalProductPackaged.legalStatusOfSupply",                                                               // MakerGen.cs:256
                        Id = "MedicinalProductPackaged.legalStatusOfSupply",                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. MedicinalProductPackaged.marketingStatus
                    this.MarketingStatus = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "MarketingStatus",                                                                                           // MakerGen.cs:255
                        Path= "MedicinalProductPackaged.marketingStatus",                                                                   // MakerGen.cs:256
                        Id = "MedicinalProductPackaged.marketingStatus",                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.MarketingStatus                                                               // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. MedicinalProductPackaged.marketingAuthorization
                    this.MarketingAuthorization = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "MarketingAuthorization",                                                                                    // MakerGen.cs:255
                        Path= "MedicinalProductPackaged.marketingAuthorization",                                                            // MakerGen.cs:256
                        Id = "MedicinalProductPackaged.marketingAuthorization",                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization"                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. MedicinalProductPackaged.manufacturer
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:255
                        Path= "MedicinalProductPackaged.manufacturer",                                                                      // MakerGen.cs:256
                        Id = "MedicinalProductPackaged.manufacturer",                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Description.Write(sDef);                                                                                                    // MakerGen.cs:240
                LegalStatusOfSupply.Write(sDef);                                                                                            // MakerGen.cs:240
                MarketingStatus.Write(sDef);                                                                                                // MakerGen.cs:240
                MarketingAuthorization.Write(sDef);                                                                                         // MakerGen.cs:240
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public MedicinalProductPackaged_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public MedicinalProductPackaged()                                                                                                   // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new MedicinalProductPackaged_Elements();                                                                        // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
