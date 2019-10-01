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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'MedicinalProductPackaged'
    /// </summary>
    // 0. MedicinalProductPackaged
    public class MedicinalProductPackaged : FhirKhit.Maker.Common.Resource.ResourceBase                                                     // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class MedicinalProductPackaged_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 8. MedicinalProductPackaged.batchIdentifier
            public class Type_BatchIdentifier : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_BatchIdentifier_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 9. MedicinalProductPackaged.batchIdentifier.outerPackaging
                    public ElementDefinitionInfo OuterPackaging;                                                                            // MakerGen.cs:216
                    // 10. MedicinalProductPackaged.batchIdentifier.immediatePackaging
                    public ElementDefinitionInfo ImmediatePackaging;                                                                        // MakerGen.cs:216
                    public Type_BatchIdentifier_Elements()                                                                                  // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 9. MedicinalProductPackaged.batchIdentifier.outerPackaging
                            this.OuterPackaging = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "OuterPackaging",                                                                                    // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.batchIdentifier.outerPackaging",                                            // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.batchIdentifier.outerPackaging",                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 10. MedicinalProductPackaged.batchIdentifier.immediatePackaging
                            this.ImmediatePackaging = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ImmediatePackaging",                                                                                // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.batchIdentifier.immediatePackaging",                                        // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.batchIdentifier.immediatePackaging",                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        OuterPackaging.Write(sDef);                                                                                         // MakerGen.cs:220
                        ImmediatePackaging.Write(sDef);                                                                                     // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_BatchIdentifier_Elements Elements { get; }                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_BatchIdentifier()                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_BatchIdentifier_Elements();                                                                    // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 11. MedicinalProductPackaged.packageItem
            public class Type_PackageItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_PackageItem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 12. MedicinalProductPackaged.packageItem.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:216
                    // 13. MedicinalProductPackaged.packageItem.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 14. MedicinalProductPackaged.packageItem.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:216
                    // 15. MedicinalProductPackaged.packageItem.material
                    public ElementDefinitionInfo Material;                                                                                  // MakerGen.cs:216
                    // 16. MedicinalProductPackaged.packageItem.alternateMaterial
                    public ElementDefinitionInfo AlternateMaterial;                                                                         // MakerGen.cs:216
                    // 17. MedicinalProductPackaged.packageItem.device
                    public ElementDefinitionInfo Device;                                                                                    // MakerGen.cs:216
                    // 18. MedicinalProductPackaged.packageItem.manufacturedItem
                    public ElementDefinitionInfo ManufacturedItem;                                                                          // MakerGen.cs:216
                    // 19. MedicinalProductPackaged.packageItem.packageItem
                    public ElementDefinitionInfo PackageItem;                                                                               // MakerGen.cs:216
                    // 20. MedicinalProductPackaged.packageItem.physicalCharacteristics
                    public ElementDefinitionInfo PhysicalCharacteristics;                                                                   // MakerGen.cs:216
                    // 21. MedicinalProductPackaged.packageItem.otherCharacteristics
                    public ElementDefinitionInfo OtherCharacteristics;                                                                      // MakerGen.cs:216
                    // 22. MedicinalProductPackaged.packageItem.shelfLifeStorage
                    public ElementDefinitionInfo ShelfLifeStorage;                                                                          // MakerGen.cs:216
                    // 23. MedicinalProductPackaged.packageItem.manufacturer
                    public ElementDefinitionInfo Manufacturer;                                                                              // MakerGen.cs:216
                    public Type_PackageItem_Elements()                                                                                      // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. MedicinalProductPackaged.packageItem.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Identifier",                                                                                        // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.identifier",                                                    // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.identifier",                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. MedicinalProductPackaged.packageItem.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.type",                                                          // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.type",                                                           // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. MedicinalProductPackaged.packageItem.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Quantity",                                                                                          // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.quantity",                                                      // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.quantity",                                                       // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. MedicinalProductPackaged.packageItem.material
                            this.Material = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Material",                                                                                          // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.material",                                                      // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.material",                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. MedicinalProductPackaged.packageItem.alternateMaterial
                            this.AlternateMaterial = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AlternateMaterial",                                                                                 // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.alternateMaterial",                                             // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.alternateMaterial",                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 17. MedicinalProductPackaged.packageItem.device
                            this.Device = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Device",                                                                                            // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.device",                                                        // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.device",                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                      // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. MedicinalProductPackaged.packageItem.manufacturedItem
                            this.ManufacturedItem = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ManufacturedItem",                                                                                  // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.manufacturedItem",                                              // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.manufacturedItem",                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured"                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. MedicinalProductPackaged.packageItem.packageItem
                            this.PackageItem = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PackageItem",                                                                                       // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.packageItem",                                                   // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.packageItem",                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. MedicinalProductPackaged.packageItem.physicalCharacteristics
                            this.PhysicalCharacteristics = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PhysicalCharacteristics",                                                                           // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.physicalCharacteristics",                                       // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.physicalCharacteristics",                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.ProdCharacteristic                                                    // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. MedicinalProductPackaged.packageItem.otherCharacteristics
                            this.OtherCharacteristics = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "OtherCharacteristics",                                                                              // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.otherCharacteristics",                                          // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.otherCharacteristics",                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. MedicinalProductPackaged.packageItem.shelfLifeStorage
                            this.ShelfLifeStorage = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ShelfLifeStorage",                                                                                  // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.shelfLifeStorage",                                              // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.shelfLifeStorage",                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.ProductShelfLife                                                      // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. MedicinalProductPackaged.packageItem.manufacturer
                            this.Manufacturer = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Manufacturer",                                                                                      // MakerGen.cs:235
                                Path= "MedicinalProductPackaged.packageItem.manufacturer",                                                  // MakerGen.cs:236
                                Id = "MedicinalProductPackaged.packageItem.manufacturer",                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:220
                        Material.Write(sDef);                                                                                               // MakerGen.cs:220
                        AlternateMaterial.Write(sDef);                                                                                      // MakerGen.cs:220
                        Device.Write(sDef);                                                                                                 // MakerGen.cs:220
                        ManufacturedItem.Write(sDef);                                                                                       // MakerGen.cs:220
                        PackageItem.Write(sDef);                                                                                            // MakerGen.cs:220
                        PhysicalCharacteristics.Write(sDef);                                                                                // MakerGen.cs:220
                        OtherCharacteristics.Write(sDef);                                                                                   // MakerGen.cs:220
                        ShelfLifeStorage.Write(sDef);                                                                                       // MakerGen.cs:220
                        Manufacturer.Write(sDef);                                                                                           // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_PackageItem_Elements Elements { get; }                                                                          // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_PackageItem()                                                                                                   // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_PackageItem_Elements();                                                                        // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. MedicinalProductPackaged.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. MedicinalProductPackaged.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 3. MedicinalProductPackaged.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 4. MedicinalProductPackaged.legalStatusOfSupply
            public ElementDefinitionInfo LegalStatusOfSupply;                                                                               // MakerGen.cs:216
            // 5. MedicinalProductPackaged.marketingStatus
            public ElementDefinitionInfo MarketingStatus;                                                                                   // MakerGen.cs:216
            // 6. MedicinalProductPackaged.marketingAuthorization
            public ElementDefinitionInfo MarketingAuthorization;                                                                            // MakerGen.cs:216
            // 7. MedicinalProductPackaged.manufacturer
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:216
            // 8. MedicinalProductPackaged.batchIdentifier
            public ElementDefinitionInfo BatchIdentifier;                                                                                   // MakerGen.cs:216
            // 11. MedicinalProductPackaged.packageItem
            public ElementDefinitionInfo PackageItem;                                                                                       // MakerGen.cs:216
            public MedicinalProductPackaged_Elements()                                                                                      // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicinalProductPackaged.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.identifier",                                                                        // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.identifier",                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MedicinalProductPackaged.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.subject",                                                                           // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.subject",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. MedicinalProductPackaged.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.description",                                                                       // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.description",                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. MedicinalProductPackaged.legalStatusOfSupply
                    this.LegalStatusOfSupply = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LegalStatusOfSupply",                                                                                       // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.legalStatusOfSupply",                                                               // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.legalStatusOfSupply",                                                                // MakerGen.cs:237
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
                    // 5. MedicinalProductPackaged.marketingStatus
                    this.MarketingStatus = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MarketingStatus",                                                                                           // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.marketingStatus",                                                                   // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.marketingStatus",                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.MarketingStatus                                                               // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. MedicinalProductPackaged.marketingAuthorization
                    this.MarketingAuthorization = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MarketingAuthorization",                                                                                    // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.marketingAuthorization",                                                            // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.marketingAuthorization",                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization"                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. MedicinalProductPackaged.manufacturer
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.manufacturer",                                                                      // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.manufacturer",                                                                       // MakerGen.cs:237
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
                    // 8. MedicinalProductPackaged.batchIdentifier
                    this.BatchIdentifier = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "BatchIdentifier",                                                                                           // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.batchIdentifier",                                                                   // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.batchIdentifier",                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_BatchIdentifier                                                                                        // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. MedicinalProductPackaged.packageItem
                    this.PackageItem = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PackageItem",                                                                                               // MakerGen.cs:235
                        Path= "MedicinalProductPackaged.packageItem",                                                                       // MakerGen.cs:236
                        Id = "MedicinalProductPackaged.packageItem",                                                                        // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_PackageItem                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                LegalStatusOfSupply.Write(sDef);                                                                                            // MakerGen.cs:220
                MarketingStatus.Write(sDef);                                                                                                // MakerGen.cs:220
                MarketingAuthorization.Write(sDef);                                                                                         // MakerGen.cs:220
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:220
                BatchIdentifier.Write(sDef);                                                                                                // MakerGen.cs:220
                PackageItem.Write(sDef);                                                                                                    // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public MedicinalProductPackaged_Elements Elements { get; }                                                                          // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public MedicinalProductPackaged()                                                                                                   // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new MedicinalProductPackaged_Elements();                                                                        // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
