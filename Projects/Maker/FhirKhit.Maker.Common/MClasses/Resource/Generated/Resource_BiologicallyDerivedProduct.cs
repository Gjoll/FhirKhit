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
      "id": "BiologicallyDerivedProduct",
      "url": "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct",
      "version": "4.0.0",
      "name": "BiologicallyDerivedProduct",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A material substance originating from a biological entity intended to be transplanted or infused\ninto another (possibly the same) biological entity.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "BiologicallyDerivedProduct",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "BiologicallyDerivedProduct",
            "path": "BiologicallyDerivedProduct",
            "short": "A material substance originating from a biological entity",
            "definition": "A material substance originating from a biological entity intended to be transplanted or infused\ninto another (possibly the same) biological entity.",
            "comment": "Substances include, but are not limited to: whole blood, bone marrow, organs, and manipulated blood cells.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "BiologicallyDerivedProduct.identifier",
            "path": "BiologicallyDerivedProduct.identifier",
            "short": "External ids for this item",
            "definition": "This records identifiers associated with this biologically derived product instance that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate (e.g. in CDA documents, or in written / printed documentation).",
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
            "id": "BiologicallyDerivedProduct.productCategory",
            "path": "BiologicallyDerivedProduct.productCategory",
            "short": "organ | tissue | fluid | cells | biologicalAgent",
            "definition": "Broad category of this product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "BiologicallyDerivedProductCategory"
                }
              ],
              "strength": "required",
              "description": "Biologically Derived Product Category.",
              "valueSet": "http://hl7.org/fhir/ValueSet/product-category|4.0.0"
            }
          },
          {
            "id": "BiologicallyDerivedProduct.productCode",
            "path": "BiologicallyDerivedProduct.productCode",
            "short": "What this biologically derived product is",
            "definition": "A code that identifies the kind of this biologically derived product (SNOMED Ctcode).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "BiologicallyDerivedProductCode"
                }
              ],
              "strength": "example",
              "description": "Biologically Derived Product Code."
            }
          },
          {
            "id": "BiologicallyDerivedProduct.status",
            "path": "BiologicallyDerivedProduct.status",
            "short": "available | unavailable",
            "definition": "Whether the product is currently available.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "BiologicallyDerivedProductStatus"
                }
              ],
              "strength": "required",
              "description": "Biologically Derived Product Status.",
              "valueSet": "http://hl7.org/fhir/ValueSet/product-status|4.0.0"
            }
          },
          {
            "id": "BiologicallyDerivedProduct.request",
            "path": "BiologicallyDerivedProduct.request",
            "short": "Procedure request",
            "definition": "Procedure request to obtain this biologically derived product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.quantity",
            "path": "BiologicallyDerivedProduct.quantity",
            "short": "The amount of this biologically derived product",
            "definition": "Number of discrete units within this product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.parent",
            "path": "BiologicallyDerivedProduct.parent",
            "short": "BiologicallyDerivedProduct parent",
            "definition": "Parent product (if any).",
            "comment": "For products that have multiple collections. For example Peripheral Blood Stem Cells may be collected over several days from a single donor and the donation split into in multiple containers which must be linked to the parent donation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct"
                ]
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.collection",
            "path": "BiologicallyDerivedProduct.collection",
            "short": "How this product was collected",
            "definition": "How this product was collected.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.collection.collector",
            "path": "BiologicallyDerivedProduct.collection.collector",
            "short": "Individual performing collection",
            "definition": "Healthcare professional who is performing the collection.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.collection.source",
            "path": "BiologicallyDerivedProduct.collection.source",
            "short": "Who is product from",
            "definition": "The patient or entity, such as a hospital or vendor in the case of a processed/manipulated/manufactured product, providing the product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.collection.collected[x]",
            "path": "BiologicallyDerivedProduct.collection.collected[x]",
            "short": "Time of product collection",
            "definition": "Time of product collection.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.processing",
            "path": "BiologicallyDerivedProduct.processing",
            "short": "Any processing of the product during collection",
            "definition": "Any processing of the product during collection that does not change the fundamental nature of the product. For example adding anti-coagulants during the collection of Peripheral Blood Stem Cells.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.processing.description",
            "path": "BiologicallyDerivedProduct.processing.description",
            "short": "Description of of processing",
            "definition": "Description of of processing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.processing.procedure",
            "path": "BiologicallyDerivedProduct.processing.procedure",
            "short": "Procesing code",
            "definition": "Procesing code.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "BiologicallyDerivedProductProcedure"
                }
              ],
              "strength": "example",
              "description": "Biologically Derived Product Procedure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-code"
            }
          },
          {
            "id": "BiologicallyDerivedProduct.processing.additive",
            "path": "BiologicallyDerivedProduct.processing.additive",
            "short": "Substance added during processing",
            "definition": "Substance added during processing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.processing.time[x]",
            "path": "BiologicallyDerivedProduct.processing.time[x]",
            "short": "Time of processing",
            "definition": "Time of processing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.manipulation",
            "path": "BiologicallyDerivedProduct.manipulation",
            "short": "Any manipulation of product post-collection",
            "definition": "Any manipulation of product post-collection that is intended to alter the product.  For example a buffy-coat enrichment or CD8 reduction of Peripheral Blood Stem Cells to make it more suitable for infusion.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.manipulation.description",
            "path": "BiologicallyDerivedProduct.manipulation.description",
            "short": "Description of manipulation",
            "definition": "Description of manipulation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.manipulation.time[x]",
            "path": "BiologicallyDerivedProduct.manipulation.time[x]",
            "short": "Time of manipulation",
            "definition": "Time of manipulation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.storage",
            "path": "BiologicallyDerivedProduct.storage",
            "short": "Product storage",
            "definition": "Product storage.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.storage.description",
            "path": "BiologicallyDerivedProduct.storage.description",
            "short": "Description of storage",
            "definition": "Description of storage.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.storage.temperature",
            "path": "BiologicallyDerivedProduct.storage.temperature",
            "short": "Storage temperature",
            "definition": "Storage temperature.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "BiologicallyDerivedProduct.storage.scale",
            "path": "BiologicallyDerivedProduct.storage.scale",
            "short": "farenheit | celsius | kelvin",
            "definition": "Temperature scale used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "BiologicallyDerivedProductStorageScale"
                }
              ],
              "strength": "required",
              "description": "BiologicallyDerived Product Storage Scale.",
              "valueSet": "http://hl7.org/fhir/ValueSet/product-storage-scale|4.0.0"
            }
          },
          {
            "id": "BiologicallyDerivedProduct.storage.duration",
            "path": "BiologicallyDerivedProduct.storage.duration",
            "short": "Storage timeperiod",
            "definition": "Storage timeperiod.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'BiologicallyDerivedProduct'
    /// </summary>
    // 0. BiologicallyDerivedProduct
    public class Resource_BiologicallyDerivedProduct : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 8. BiologicallyDerivedProduct.collection
        public class Type_Collection : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 9. BiologicallyDerivedProduct.collection.collector
            public ElementDefinitionInfo Element_Collector;
            // 10. BiologicallyDerivedProduct.collection.source
            public ElementDefinitionInfo Element_Source;
            // 11. BiologicallyDerivedProduct.collection.collected[x]
            public ElementDefinitionInfo Element_Collected;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "BiologicallyDerivedProduct.collection",
                    ElementId = "BiologicallyDerivedProduct.collection"
                });
                Element_Collector.Write(sDef);
                Element_Source.Write(sDef);
                Element_Collected.Write(sDef);
            }
            
            public Type_Collection()
            {
                {
                    // 9. BiologicallyDerivedProduct.collection.collector
                    this.Element_Collector = new ElementDefinitionInfo
                    {
                        Name = "Element_Collector",
                        Path= "BiologicallyDerivedProduct.collection.collector",
                        Id = "BiologicallyDerivedProduct.collection.collector",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                                }
                            }
                        }
                    };
                }
                {
                    // 10. BiologicallyDerivedProduct.collection.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "BiologicallyDerivedProduct.collection.source",
                        Id = "BiologicallyDerivedProduct.collection.source",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
                {
                    // 11. BiologicallyDerivedProduct.collection.collected[x]
                    this.Element_Collected = new ElementDefinitionInfo
                    {
                        Name = "Element_Collected",
                        Path= "BiologicallyDerivedProduct.collection.collected[x]",
                        Id = "BiologicallyDerivedProduct.collection.collected[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
            }
        }
        // 12. BiologicallyDerivedProduct.processing
        public class Type_Processing : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. BiologicallyDerivedProduct.processing.description
            public ElementDefinitionInfo Element_Description;
            // 14. BiologicallyDerivedProduct.processing.procedure
            public ElementDefinitionInfo Element_Procedure;
            // 15. BiologicallyDerivedProduct.processing.additive
            public ElementDefinitionInfo Element_Additive;
            // 16. BiologicallyDerivedProduct.processing.time[x]
            public ElementDefinitionInfo Element_Time;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "BiologicallyDerivedProduct.processing",
                    ElementId = "BiologicallyDerivedProduct.processing"
                });
                Element_Description.Write(sDef);
                Element_Procedure.Write(sDef);
                Element_Additive.Write(sDef);
                Element_Time.Write(sDef);
            }
            
            public Type_Processing()
            {
                {
                    // 13. BiologicallyDerivedProduct.processing.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "BiologicallyDerivedProduct.processing.description",
                        Id = "BiologicallyDerivedProduct.processing.description",
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
                    // 14. BiologicallyDerivedProduct.processing.procedure
                    this.Element_Procedure = new ElementDefinitionInfo
                    {
                        Name = "Element_Procedure",
                        Path= "BiologicallyDerivedProduct.processing.procedure",
                        Id = "BiologicallyDerivedProduct.processing.procedure",
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
                    // 15. BiologicallyDerivedProduct.processing.additive
                    this.Element_Additive = new ElementDefinitionInfo
                    {
                        Name = "Element_Additive",
                        Path= "BiologicallyDerivedProduct.processing.additive",
                        Id = "BiologicallyDerivedProduct.processing.additive",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Substance"
                                }
                            }
                        }
                    };
                }
                {
                    // 16. BiologicallyDerivedProduct.processing.time[x]
                    this.Element_Time = new ElementDefinitionInfo
                    {
                        Name = "Element_Time",
                        Path= "BiologicallyDerivedProduct.processing.time[x]",
                        Id = "BiologicallyDerivedProduct.processing.time[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
            }
        }
        // 17. BiologicallyDerivedProduct.manipulation
        public class Type_Manipulation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 18. BiologicallyDerivedProduct.manipulation.description
            public ElementDefinitionInfo Element_Description;
            // 19. BiologicallyDerivedProduct.manipulation.time[x]
            public ElementDefinitionInfo Element_Time;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "BiologicallyDerivedProduct.manipulation",
                    ElementId = "BiologicallyDerivedProduct.manipulation"
                });
                Element_Description.Write(sDef);
                Element_Time.Write(sDef);
            }
            
            public Type_Manipulation()
            {
                {
                    // 18. BiologicallyDerivedProduct.manipulation.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "BiologicallyDerivedProduct.manipulation.description",
                        Id = "BiologicallyDerivedProduct.manipulation.description",
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
                    // 19. BiologicallyDerivedProduct.manipulation.time[x]
                    this.Element_Time = new ElementDefinitionInfo
                    {
                        Name = "Element_Time",
                        Path= "BiologicallyDerivedProduct.manipulation.time[x]",
                        Id = "BiologicallyDerivedProduct.manipulation.time[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
            }
        }
        // 20. BiologicallyDerivedProduct.storage
        public class Type_Storage : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 21. BiologicallyDerivedProduct.storage.description
            public ElementDefinitionInfo Element_Description;
            // 22. BiologicallyDerivedProduct.storage.temperature
            public ElementDefinitionInfo Element_Temperature;
            // 23. BiologicallyDerivedProduct.storage.scale
            public ElementDefinitionInfo Element_Scale;
            // 24. BiologicallyDerivedProduct.storage.duration
            public ElementDefinitionInfo Element_Duration;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "BiologicallyDerivedProduct.storage",
                    ElementId = "BiologicallyDerivedProduct.storage"
                });
                Element_Description.Write(sDef);
                Element_Temperature.Write(sDef);
                Element_Scale.Write(sDef);
                Element_Duration.Write(sDef);
            }
            
            public Type_Storage()
            {
                {
                    // 21. BiologicallyDerivedProduct.storage.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "BiologicallyDerivedProduct.storage.description",
                        Id = "BiologicallyDerivedProduct.storage.description",
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
                    // 22. BiologicallyDerivedProduct.storage.temperature
                    this.Element_Temperature = new ElementDefinitionInfo
                    {
                        Name = "Element_Temperature",
                        Path= "BiologicallyDerivedProduct.storage.temperature",
                        Id = "BiologicallyDerivedProduct.storage.temperature",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 23. BiologicallyDerivedProduct.storage.scale
                    this.Element_Scale = new ElementDefinitionInfo
                    {
                        Name = "Element_Scale",
                        Path= "BiologicallyDerivedProduct.storage.scale",
                        Id = "BiologicallyDerivedProduct.storage.scale",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
                {
                    // 24. BiologicallyDerivedProduct.storage.duration
                    this.Element_Duration = new ElementDefinitionInfo
                    {
                        Name = "Element_Duration",
                        Path= "BiologicallyDerivedProduct.storage.duration",
                        Id = "BiologicallyDerivedProduct.storage.duration",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. BiologicallyDerivedProduct.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. BiologicallyDerivedProduct.productCategory
        public ElementDefinitionInfo Element_ProductCategory;
        // 3. BiologicallyDerivedProduct.productCode
        public ElementDefinitionInfo Element_ProductCode;
        // 4. BiologicallyDerivedProduct.status
        public ElementDefinitionInfo Element_Status;
        // 5. BiologicallyDerivedProduct.request
        public ElementDefinitionInfo Element_Request;
        // 6. BiologicallyDerivedProduct.quantity
        public ElementDefinitionInfo Element_Quantity;
        // 7. BiologicallyDerivedProduct.parent
        public ElementDefinitionInfo Element_Parent;
        // 8. BiologicallyDerivedProduct.collection
        public ElementDefinitionInfo Element_Collection;
        // 12. BiologicallyDerivedProduct.processing
        public ElementDefinitionInfo Element_Processing;
        // 17. BiologicallyDerivedProduct.manipulation
        public ElementDefinitionInfo Element_Manipulation;
        // 20. BiologicallyDerivedProduct.storage
        public ElementDefinitionInfo Element_Storage;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "BiologicallyDerivedProduct",
                ElementId = "BiologicallyDerivedProduct"
            });
            Element_Identifier.Write(sDef);
            Element_ProductCategory.Write(sDef);
            Element_ProductCode.Write(sDef);
            Element_Status.Write(sDef);
            Element_Request.Write(sDef);
            Element_Quantity.Write(sDef);
            Element_Parent.Write(sDef);
            Element_Collection.Write(sDef);
            Element_Processing.Write(sDef);
            Element_Manipulation.Write(sDef);
            Element_Storage.Write(sDef);
        }
        
        public Resource_BiologicallyDerivedProduct()
        {
            {
                // 1. BiologicallyDerivedProduct.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "BiologicallyDerivedProduct.identifier",
                    Id = "BiologicallyDerivedProduct.identifier",
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
                // 2. BiologicallyDerivedProduct.productCategory
                this.Element_ProductCategory = new ElementDefinitionInfo
                {
                    Name = "Element_ProductCategory",
                    Path= "BiologicallyDerivedProduct.productCategory",
                    Id = "BiologicallyDerivedProduct.productCategory",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 3. BiologicallyDerivedProduct.productCode
                this.Element_ProductCode = new ElementDefinitionInfo
                {
                    Name = "Element_ProductCode",
                    Path= "BiologicallyDerivedProduct.productCode",
                    Id = "BiologicallyDerivedProduct.productCode",
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
                // 4. BiologicallyDerivedProduct.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "BiologicallyDerivedProduct.status",
                    Id = "BiologicallyDerivedProduct.status",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 5. BiologicallyDerivedProduct.request
                this.Element_Request = new ElementDefinitionInfo
                {
                    Name = "Element_Request",
                    Path= "BiologicallyDerivedProduct.request",
                    Id = "BiologicallyDerivedProduct.request",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                            }
                        }
                    }
                };
            }
            {
                // 6. BiologicallyDerivedProduct.quantity
                this.Element_Quantity = new ElementDefinitionInfo
                {
                    Name = "Element_Quantity",
                    Path= "BiologicallyDerivedProduct.quantity",
                    Id = "BiologicallyDerivedProduct.quantity",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                        {
                        }
                    }
                };
            }
            {
                // 7. BiologicallyDerivedProduct.parent
                this.Element_Parent = new ElementDefinitionInfo
                {
                    Name = "Element_Parent",
                    Path= "BiologicallyDerivedProduct.parent",
                    Id = "BiologicallyDerivedProduct.parent",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct"
                            }
                        }
                    }
                };
            }
            {
                // 8. BiologicallyDerivedProduct.collection
                this.Element_Collection = new ElementDefinitionInfo
                {
                    Name = "Element_Collection",
                    Path= "BiologicallyDerivedProduct.collection",
                    Id = "BiologicallyDerivedProduct.collection",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Collection
                        {
                        }
                    }
                };
            }
            {
                // 12. BiologicallyDerivedProduct.processing
                this.Element_Processing = new ElementDefinitionInfo
                {
                    Name = "Element_Processing",
                    Path= "BiologicallyDerivedProduct.processing",
                    Id = "BiologicallyDerivedProduct.processing",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Processing
                        {
                        }
                    }
                };
            }
            {
                // 17. BiologicallyDerivedProduct.manipulation
                this.Element_Manipulation = new ElementDefinitionInfo
                {
                    Name = "Element_Manipulation",
                    Path= "BiologicallyDerivedProduct.manipulation",
                    Id = "BiologicallyDerivedProduct.manipulation",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Manipulation
                        {
                        }
                    }
                };
            }
            {
                // 20. BiologicallyDerivedProduct.storage
                this.Element_Storage = new ElementDefinitionInfo
                {
                    Name = "Element_Storage",
                    Path= "BiologicallyDerivedProduct.storage",
                    Id = "BiologicallyDerivedProduct.storage",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Storage
                        {
                        }
                    }
                };
            }
            this.Name = "BiologicallyDerivedProduct";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct";
        }
    }
}
