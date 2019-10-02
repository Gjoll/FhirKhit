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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MedicinalProductPackaged'
    /// </summary>
    // 0. MedicinalProductPackaged
    public class Resource_MedicinalProductPackaged : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 8. MedicinalProductPackaged.batchIdentifier
        public class Type_BatchIdentifier : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 9. MedicinalProductPackaged.batchIdentifier.outerPackaging
            public ElementDefinitionInfo Element_OuterPackaging;                                                                            // MakerGen.cs:219
            // 10. MedicinalProductPackaged.batchIdentifier.immediatePackaging
            public ElementDefinitionInfo Element_ImmediatePackaging;                                                                        // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicinalProductPackaged.batchIdentifier",                                                                      // MakerGen.cs:395
                    ElementId = "MedicinalProductPackaged.batchIdentifier"                                                                  // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_OuterPackaging.Write(sDef);                                                                                         // MakerGen.cs:223
                Element_ImmediatePackaging.Write(sDef);                                                                                     // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_BatchIdentifier()                                                                                                   // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 9. MedicinalProductPackaged.batchIdentifier.outerPackaging
                    this.Element_OuterPackaging = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_OuterPackaging",                                                                                    // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.batchIdentifier.outerPackaging",                                                    // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.batchIdentifier.outerPackaging",                                                     // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 10. MedicinalProductPackaged.batchIdentifier.immediatePackaging
                    this.Element_ImmediatePackaging = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ImmediatePackaging",                                                                                // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.batchIdentifier.immediatePackaging",                                                // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.batchIdentifier.immediatePackaging",                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 11. MedicinalProductPackaged.packageItem
        public class Type_PackageItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 12. MedicinalProductPackaged.packageItem.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:219
            // 13. MedicinalProductPackaged.packageItem.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 14. MedicinalProductPackaged.packageItem.quantity
            public ElementDefinitionInfo Element_Quantity;                                                                                  // MakerGen.cs:219
            // 15. MedicinalProductPackaged.packageItem.material
            public ElementDefinitionInfo Element_Material;                                                                                  // MakerGen.cs:219
            // 16. MedicinalProductPackaged.packageItem.alternateMaterial
            public ElementDefinitionInfo Element_AlternateMaterial;                                                                         // MakerGen.cs:219
            // 17. MedicinalProductPackaged.packageItem.device
            public ElementDefinitionInfo Element_Device;                                                                                    // MakerGen.cs:219
            // 18. MedicinalProductPackaged.packageItem.manufacturedItem
            public ElementDefinitionInfo Element_ManufacturedItem;                                                                          // MakerGen.cs:219
            // 19. MedicinalProductPackaged.packageItem.packageItem
            public ElementDefinitionInfo Element_PackageItem;                                                                               // MakerGen.cs:219
            // 20. MedicinalProductPackaged.packageItem.physicalCharacteristics
            public ElementDefinitionInfo Element_PhysicalCharacteristics;                                                                   // MakerGen.cs:219
            // 21. MedicinalProductPackaged.packageItem.otherCharacteristics
            public ElementDefinitionInfo Element_OtherCharacteristics;                                                                      // MakerGen.cs:219
            // 22. MedicinalProductPackaged.packageItem.shelfLifeStorage
            public ElementDefinitionInfo Element_ShelfLifeStorage;                                                                          // MakerGen.cs:219
            // 23. MedicinalProductPackaged.packageItem.manufacturer
            public ElementDefinitionInfo Element_Manufacturer;                                                                              // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicinalProductPackaged.packageItem",                                                                          // MakerGen.cs:395
                    ElementId = "MedicinalProductPackaged.packageItem"                                                                      // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Quantity.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Material.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_AlternateMaterial.Write(sDef);                                                                                      // MakerGen.cs:223
                Element_Device.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_ManufacturedItem.Write(sDef);                                                                                       // MakerGen.cs:223
                Element_PackageItem.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_PhysicalCharacteristics.Write(sDef);                                                                                // MakerGen.cs:223
                Element_OtherCharacteristics.Write(sDef);                                                                                   // MakerGen.cs:223
                Element_ShelfLifeStorage.Write(sDef);                                                                                       // MakerGen.cs:223
                Element_Manufacturer.Write(sDef);                                                                                           // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_PackageItem()                                                                                                       // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 12. MedicinalProductPackaged.packageItem.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.identifier",                                                            // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.identifier",                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 13. MedicinalProductPackaged.packageItem.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.type",                                                                  // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.type",                                                                   // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. MedicinalProductPackaged.packageItem.quantity
                    this.Element_Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.quantity",                                                              // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.quantity",                                                               // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. MedicinalProductPackaged.packageItem.material
                    this.Element_Material = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Material",                                                                                          // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.material",                                                              // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.material",                                                               // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. MedicinalProductPackaged.packageItem.alternateMaterial
                    this.Element_AlternateMaterial = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_AlternateMaterial",                                                                                 // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.alternateMaterial",                                                     // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.alternateMaterial",                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 17. MedicinalProductPackaged.packageItem.device
                    this.Element_Device = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Device",                                                                                            // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.device",                                                                // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.device",                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 18. MedicinalProductPackaged.packageItem.manufacturedItem
                    this.Element_ManufacturedItem = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ManufacturedItem",                                                                                  // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.manufacturedItem",                                                      // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.manufacturedItem",                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured"                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 19. MedicinalProductPackaged.packageItem.packageItem
                    this.Element_PackageItem = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_PackageItem",                                                                                       // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.packageItem",                                                           // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.packageItem",                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 20. MedicinalProductPackaged.packageItem.physicalCharacteristics
                    this.Element_PhysicalCharacteristics = new ElementDefinitionInfo                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_PhysicalCharacteristics",                                                                           // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.physicalCharacteristics",                                               // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.physicalCharacteristics",                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_ProdCharacteristic                                                       // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 21. MedicinalProductPackaged.packageItem.otherCharacteristics
                    this.Element_OtherCharacteristics = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_OtherCharacteristics",                                                                              // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.otherCharacteristics",                                                  // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.otherCharacteristics",                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 22. MedicinalProductPackaged.packageItem.shelfLifeStorage
                    this.Element_ShelfLifeStorage = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ShelfLifeStorage",                                                                                  // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.shelfLifeStorage",                                                      // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.shelfLifeStorage",                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_ProductShelfLife                                                         // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 23. MedicinalProductPackaged.packageItem.manufacturer
                    this.Element_Manufacturer = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Manufacturer",                                                                                      // MakerGen.cs:238
                        Path= "MedicinalProductPackaged.packageItem.manufacturer",                                                          // MakerGen.cs:239
                        Id = "MedicinalProductPackaged.packageItem.manufacturer",                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. MedicinalProductPackaged.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. MedicinalProductPackaged.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:219
        // 3. MedicinalProductPackaged.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:219
        // 4. MedicinalProductPackaged.legalStatusOfSupply
        public ElementDefinitionInfo Element_LegalStatusOfSupply;                                                                           // MakerGen.cs:219
        // 5. MedicinalProductPackaged.marketingStatus
        public ElementDefinitionInfo Element_MarketingStatus;                                                                               // MakerGen.cs:219
        // 6. MedicinalProductPackaged.marketingAuthorization
        public ElementDefinitionInfo Element_MarketingAuthorization;                                                                        // MakerGen.cs:219
        // 7. MedicinalProductPackaged.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;                                                                                  // MakerGen.cs:219
        // 8. MedicinalProductPackaged.batchIdentifier
        public ElementDefinitionInfo Element_BatchIdentifier;                                                                               // MakerGen.cs:219
        // 11. MedicinalProductPackaged.packageItem
        public ElementDefinitionInfo Element_PackageItem;                                                                                   // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MedicinalProductPackaged",                                                                                          // MakerGen.cs:395
                ElementId = "MedicinalProductPackaged"                                                                                      // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_LegalStatusOfSupply.Write(sDef);                                                                                        // MakerGen.cs:223
            Element_MarketingStatus.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_MarketingAuthorization.Write(sDef);                                                                                     // MakerGen.cs:223
            Element_Manufacturer.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_BatchIdentifier.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_PackageItem.Write(sDef);                                                                                                // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MedicinalProductPackaged()                                                                                          // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MedicinalProductPackaged.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.identifier",                                                                            // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.identifier",                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. MedicinalProductPackaged.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.subject",                                                                               // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.subject",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProduct"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. MedicinalProductPackaged.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Description",                                                                                           // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.description",                                                                           // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.description",                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. MedicinalProductPackaged.legalStatusOfSupply
                this.Element_LegalStatusOfSupply = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_LegalStatusOfSupply",                                                                                   // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.legalStatusOfSupply",                                                                   // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.legalStatusOfSupply",                                                                    // MakerGen.cs:240
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
                // 5. MedicinalProductPackaged.marketingStatus
                this.Element_MarketingStatus = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MarketingStatus",                                                                                       // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.marketingStatus",                                                                       // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.marketingStatus",                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_MarketingStatus                                                              // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. MedicinalProductPackaged.marketingAuthorization
                this.Element_MarketingAuthorization = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MarketingAuthorization",                                                                                // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.marketingAuthorization",                                                                // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.marketingAuthorization",                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization"                                     // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. MedicinalProductPackaged.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.manufacturer",                                                                          // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.manufacturer",                                                                           // MakerGen.cs:240
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
                // 8. MedicinalProductPackaged.batchIdentifier
                this.Element_BatchIdentifier = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_BatchIdentifier",                                                                                       // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.batchIdentifier",                                                                       // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.batchIdentifier",                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_BatchIdentifier                                                                                            // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. MedicinalProductPackaged.packageItem
                this.Element_PackageItem = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PackageItem",                                                                                           // MakerGen.cs:238
                    Path= "MedicinalProductPackaged.packageItem",                                                                           // MakerGen.cs:239
                    Id = "MedicinalProductPackaged.packageItem",                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_PackageItem                                                                                                // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MedicinalProductPackaged";                                                                                         // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged";                                                  // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
