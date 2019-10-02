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
    #endregion
    /// <summary>
    /// Fhir resource 'MedicinalProductPackaged'
    /// </summary>
    // 0. MedicinalProductPackaged
    public class Resource_MedicinalProductPackaged : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 8. MedicinalProductPackaged.batchIdentifier
        public class Type_BatchIdentifier : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 9. MedicinalProductPackaged.batchIdentifier.outerPackaging
            public ElementDefinitionInfo Element_OuterPackaging;
            // 10. MedicinalProductPackaged.batchIdentifier.immediatePackaging
            public ElementDefinitionInfo Element_ImmediatePackaging;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductPackaged.batchIdentifier",
                    ElementId = "MedicinalProductPackaged.batchIdentifier"
                });
                Element_OuterPackaging.Write(sDef);
                Element_ImmediatePackaging.Write(sDef);
            }
            
            public Type_BatchIdentifier()
            {
                {
                    // 9. MedicinalProductPackaged.batchIdentifier.outerPackaging
                    this.Element_OuterPackaging = new ElementDefinitionInfo
                    {
                        Name = "Element_OuterPackaging",
                        Path= "MedicinalProductPackaged.batchIdentifier.outerPackaging",
                        Id = "MedicinalProductPackaged.batchIdentifier.outerPackaging",
                        Min = 1,
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
                    // 10. MedicinalProductPackaged.batchIdentifier.immediatePackaging
                    this.Element_ImmediatePackaging = new ElementDefinitionInfo
                    {
                        Name = "Element_ImmediatePackaging",
                        Path= "MedicinalProductPackaged.batchIdentifier.immediatePackaging",
                        Id = "MedicinalProductPackaged.batchIdentifier.immediatePackaging",
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
            }
        }
        // 11. MedicinalProductPackaged.packageItem
        public class Type_PackageItem : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 12. MedicinalProductPackaged.packageItem.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 13. MedicinalProductPackaged.packageItem.type
            public ElementDefinitionInfo Element_Type;
            // 14. MedicinalProductPackaged.packageItem.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 15. MedicinalProductPackaged.packageItem.material
            public ElementDefinitionInfo Element_Material;
            // 16. MedicinalProductPackaged.packageItem.alternateMaterial
            public ElementDefinitionInfo Element_AlternateMaterial;
            // 17. MedicinalProductPackaged.packageItem.device
            public ElementDefinitionInfo Element_Device;
            // 18. MedicinalProductPackaged.packageItem.manufacturedItem
            public ElementDefinitionInfo Element_ManufacturedItem;
            // 19. MedicinalProductPackaged.packageItem.packageItem
            public ElementDefinitionInfo Element_PackageItem;
            // 20. MedicinalProductPackaged.packageItem.physicalCharacteristics
            public ElementDefinitionInfo Element_PhysicalCharacteristics;
            // 21. MedicinalProductPackaged.packageItem.otherCharacteristics
            public ElementDefinitionInfo Element_OtherCharacteristics;
            // 22. MedicinalProductPackaged.packageItem.shelfLifeStorage
            public ElementDefinitionInfo Element_ShelfLifeStorage;
            // 23. MedicinalProductPackaged.packageItem.manufacturer
            public ElementDefinitionInfo Element_Manufacturer;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductPackaged.packageItem",
                    ElementId = "MedicinalProductPackaged.packageItem"
                });
                Element_Identifier.Write(sDef);
                Element_Type.Write(sDef);
                Element_Quantity.Write(sDef);
                Element_Material.Write(sDef);
                Element_AlternateMaterial.Write(sDef);
                Element_Device.Write(sDef);
                Element_ManufacturedItem.Write(sDef);
                Element_PackageItem.Write(sDef);
                Element_PhysicalCharacteristics.Write(sDef);
                Element_OtherCharacteristics.Write(sDef);
                Element_ShelfLifeStorage.Write(sDef);
                Element_Manufacturer.Write(sDef);
            }
            
            public Type_PackageItem()
            {
                {
                    // 12. MedicinalProductPackaged.packageItem.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "MedicinalProductPackaged.packageItem.identifier",
                        Id = "MedicinalProductPackaged.packageItem.identifier",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 13. MedicinalProductPackaged.packageItem.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicinalProductPackaged.packageItem.type",
                        Id = "MedicinalProductPackaged.packageItem.type",
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
                    // 14. MedicinalProductPackaged.packageItem.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "MedicinalProductPackaged.packageItem.quantity",
                        Id = "MedicinalProductPackaged.packageItem.quantity",
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
                    // 15. MedicinalProductPackaged.packageItem.material
                    this.Element_Material = new ElementDefinitionInfo
                    {
                        Name = "Element_Material",
                        Path= "MedicinalProductPackaged.packageItem.material",
                        Id = "MedicinalProductPackaged.packageItem.material",
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
                {
                    // 16. MedicinalProductPackaged.packageItem.alternateMaterial
                    this.Element_AlternateMaterial = new ElementDefinitionInfo
                    {
                        Name = "Element_AlternateMaterial",
                        Path= "MedicinalProductPackaged.packageItem.alternateMaterial",
                        Id = "MedicinalProductPackaged.packageItem.alternateMaterial",
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
                {
                    // 17. MedicinalProductPackaged.packageItem.device
                    this.Element_Device = new ElementDefinitionInfo
                    {
                        Name = "Element_Device",
                        Path= "MedicinalProductPackaged.packageItem.device",
                        Id = "MedicinalProductPackaged.packageItem.device",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"
                                }
                            }
                        }
                    };
                }
                {
                    // 18. MedicinalProductPackaged.packageItem.manufacturedItem
                    this.Element_ManufacturedItem = new ElementDefinitionInfo
                    {
                        Name = "Element_ManufacturedItem",
                        Path= "MedicinalProductPackaged.packageItem.manufacturedItem",
                        Id = "MedicinalProductPackaged.packageItem.manufacturedItem",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured"
                                }
                            }
                        }
                    };
                }
                {
                    // 19. MedicinalProductPackaged.packageItem.packageItem
                    this.Element_PackageItem = new ElementDefinitionInfo
                    {
                        Name = "Element_PackageItem",
                        Path= "MedicinalProductPackaged.packageItem.packageItem",
                        Id = "MedicinalProductPackaged.packageItem.packageItem",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
                {
                    // 20. MedicinalProductPackaged.packageItem.physicalCharacteristics
                    this.Element_PhysicalCharacteristics = new ElementDefinitionInfo
                    {
                        Name = "Element_PhysicalCharacteristics",
                        Path= "MedicinalProductPackaged.packageItem.physicalCharacteristics",
                        Id = "MedicinalProductPackaged.packageItem.physicalCharacteristics",
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
                    // 21. MedicinalProductPackaged.packageItem.otherCharacteristics
                    this.Element_OtherCharacteristics = new ElementDefinitionInfo
                    {
                        Name = "Element_OtherCharacteristics",
                        Path= "MedicinalProductPackaged.packageItem.otherCharacteristics",
                        Id = "MedicinalProductPackaged.packageItem.otherCharacteristics",
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
                {
                    // 22. MedicinalProductPackaged.packageItem.shelfLifeStorage
                    this.Element_ShelfLifeStorage = new ElementDefinitionInfo
                    {
                        Name = "Element_ShelfLifeStorage",
                        Path= "MedicinalProductPackaged.packageItem.shelfLifeStorage",
                        Id = "MedicinalProductPackaged.packageItem.shelfLifeStorage",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_ProductShelfLife
                            {
                            }
                        }
                    };
                }
                {
                    // 23. MedicinalProductPackaged.packageItem.manufacturer
                    this.Element_Manufacturer = new ElementDefinitionInfo
                    {
                        Name = "Element_Manufacturer",
                        Path= "MedicinalProductPackaged.packageItem.manufacturer",
                        Id = "MedicinalProductPackaged.packageItem.manufacturer",
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
            }
        }
        // 1. MedicinalProductPackaged.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. MedicinalProductPackaged.subject
        public ElementDefinitionInfo Element_Subject;
        // 3. MedicinalProductPackaged.description
        public ElementDefinitionInfo Element_Description;
        // 4. MedicinalProductPackaged.legalStatusOfSupply
        public ElementDefinitionInfo Element_LegalStatusOfSupply;
        // 5. MedicinalProductPackaged.marketingStatus
        public ElementDefinitionInfo Element_MarketingStatus;
        // 6. MedicinalProductPackaged.marketingAuthorization
        public ElementDefinitionInfo Element_MarketingAuthorization;
        // 7. MedicinalProductPackaged.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;
        // 8. MedicinalProductPackaged.batchIdentifier
        public ElementDefinitionInfo Element_BatchIdentifier;
        // 11. MedicinalProductPackaged.packageItem
        public ElementDefinitionInfo Element_PackageItem;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductPackaged",
                ElementId = "MedicinalProductPackaged"
            });
            Element_Identifier.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Description.Write(sDef);
            Element_LegalStatusOfSupply.Write(sDef);
            Element_MarketingStatus.Write(sDef);
            Element_MarketingAuthorization.Write(sDef);
            Element_Manufacturer.Write(sDef);
            Element_BatchIdentifier.Write(sDef);
            Element_PackageItem.Write(sDef);
        }
        
        public Resource_MedicinalProductPackaged()
        {
            {
                // 1. MedicinalProductPackaged.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "MedicinalProductPackaged.identifier",
                    Id = "MedicinalProductPackaged.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. MedicinalProductPackaged.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "MedicinalProductPackaged.subject",
                    Id = "MedicinalProductPackaged.subject",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProduct"
                            }
                        }
                    }
                };
            }
            {
                // 3. MedicinalProductPackaged.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "MedicinalProductPackaged.description",
                    Id = "MedicinalProductPackaged.description",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 4. MedicinalProductPackaged.legalStatusOfSupply
                this.Element_LegalStatusOfSupply = new ElementDefinitionInfo
                {
                    Name = "Element_LegalStatusOfSupply",
                    Path= "MedicinalProductPackaged.legalStatusOfSupply",
                    Id = "MedicinalProductPackaged.legalStatusOfSupply",
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
                // 5. MedicinalProductPackaged.marketingStatus
                this.Element_MarketingStatus = new ElementDefinitionInfo
                {
                    Name = "Element_MarketingStatus",
                    Path= "MedicinalProductPackaged.marketingStatus",
                    Id = "MedicinalProductPackaged.marketingStatus",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_MarketingStatus
                        {
                        }
                    }
                };
            }
            {
                // 6. MedicinalProductPackaged.marketingAuthorization
                this.Element_MarketingAuthorization = new ElementDefinitionInfo
                {
                    Name = "Element_MarketingAuthorization",
                    Path= "MedicinalProductPackaged.marketingAuthorization",
                    Id = "MedicinalProductPackaged.marketingAuthorization",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization"
                            }
                        }
                    }
                };
            }
            {
                // 7. MedicinalProductPackaged.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo
                {
                    Name = "Element_Manufacturer",
                    Path= "MedicinalProductPackaged.manufacturer",
                    Id = "MedicinalProductPackaged.manufacturer",
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
                // 8. MedicinalProductPackaged.batchIdentifier
                this.Element_BatchIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_BatchIdentifier",
                    Path= "MedicinalProductPackaged.batchIdentifier",
                    Id = "MedicinalProductPackaged.batchIdentifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_BatchIdentifier
                        {
                        }
                    }
                };
            }
            {
                // 11. MedicinalProductPackaged.packageItem
                this.Element_PackageItem = new ElementDefinitionInfo
                {
                    Name = "Element_PackageItem",
                    Path= "MedicinalProductPackaged.packageItem",
                    Id = "MedicinalProductPackaged.packageItem",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_PackageItem
                        {
                        }
                    }
                };
            }
            this.Name = "MedicinalProductPackaged";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged";
        }
    }
}
