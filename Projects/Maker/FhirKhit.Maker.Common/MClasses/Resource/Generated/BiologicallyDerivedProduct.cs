using System;                                                                                                                               // MakerGen.cs:413
using System.Diagnostics;                                                                                                                   // MakerGen.cs:414
using System.IO;                                                                                                                            // MakerGen.cs:415
using System.Linq;                                                                                                                          // MakerGen.cs:416
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:417
                                                                                                                                            // MakerGen.cs:418
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:419
{                                                                                                                                           // MakerGen.cs:420
    #region Json                                                                                                                            // MakerGen.cs:421
    #if NEVER                                                                                                                               // MakerGen.cs:422
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
    #endregion                                                                                                                              // MakerGen.cs:425
    /// <summary>
    /// Fhir resource 'BiologicallyDerivedProduct'
    /// </summary>
    // 0. BiologicallyDerivedProduct
    public class BiologicallyDerivedProduct : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 8. BiologicallyDerivedProduct.collection
        public class Type_Collection : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 9. BiologicallyDerivedProduct.collection.collector
            public MakerElementInstance Element_Collector;                                                                                  // MakerGen.cs:232
            // 10. BiologicallyDerivedProduct.collection.source
            public MakerElementInstance Element_Source;                                                                                     // MakerGen.cs:232
            // 11. BiologicallyDerivedProduct.collection.collected[x]
            public MakerElementInstance Element_Collected;                                                                                  // MakerGen.cs:232
            public Type_Collection()                                                                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 9. BiologicallyDerivedProduct.collection.collector
                    this.Element_Collector = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Collector",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:335
                            {                                                                                                               // MakerGen.cs:336
                                TargetProfile = new String[]                                                                                // MakerGen.cs:338
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:338
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:338
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:339
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 10. BiologicallyDerivedProduct.collection.source
                    this.Element_Source = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Source",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:335
                            {                                                                                                               // MakerGen.cs:336
                                TargetProfile = new String[]                                                                                // MakerGen.cs:338
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:338
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:338
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:339
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 11. BiologicallyDerivedProduct.collection.collected[x]
                    this.Element_Collected = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Collected",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 12. BiologicallyDerivedProduct.processing
        public class Type_Processing : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 13. BiologicallyDerivedProduct.processing.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 14. BiologicallyDerivedProduct.processing.procedure
            public MakerElementInstance Element_Procedure;                                                                                  // MakerGen.cs:232
            // 15. BiologicallyDerivedProduct.processing.additive
            public MakerElementInstance Element_Additive;                                                                                   // MakerGen.cs:232
            // 16. BiologicallyDerivedProduct.processing.time[x]
            public MakerElementInstance Element_Time;                                                                                       // MakerGen.cs:232
            public Type_Processing()                                                                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 13. BiologicallyDerivedProduct.processing.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 14. BiologicallyDerivedProduct.processing.procedure
                    this.Element_Procedure = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Procedure",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 15. BiologicallyDerivedProduct.processing.additive
                    this.Element_Additive = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Additive",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:335
                            {                                                                                                               // MakerGen.cs:336
                                TargetProfile = new String[]                                                                                // MakerGen.cs:338
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:338
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:339
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 16. BiologicallyDerivedProduct.processing.time[x]
                    this.Element_Time = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Time",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 17. BiologicallyDerivedProduct.manipulation
        public class Type_Manipulation : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 18. BiologicallyDerivedProduct.manipulation.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 19. BiologicallyDerivedProduct.manipulation.time[x]
            public MakerElementInstance Element_Time;                                                                                       // MakerGen.cs:232
            public Type_Manipulation()                                                                                                      // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 18. BiologicallyDerivedProduct.manipulation.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 19. BiologicallyDerivedProduct.manipulation.time[x]
                    this.Element_Time = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Time",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            },                                                                                                              // MakerGen.cs:293
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 20. BiologicallyDerivedProduct.storage
        public class Type_Storage : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 21. BiologicallyDerivedProduct.storage.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 22. BiologicallyDerivedProduct.storage.temperature
            public MakerElementInstance Element_Temperature;                                                                                // MakerGen.cs:232
            // 23. BiologicallyDerivedProduct.storage.scale
            public MakerElementInstance Element_Scale;                                                                                      // MakerGen.cs:232
            // 24. BiologicallyDerivedProduct.storage.duration
            public MakerElementInstance Element_Duration;                                                                                   // MakerGen.cs:232
            public Type_Storage()                                                                                                           // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 21. BiologicallyDerivedProduct.storage.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 22. BiologicallyDerivedProduct.storage.temperature
                    this.Element_Temperature = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Temperature",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 23. BiologicallyDerivedProduct.storage.scale
                    this.Element_Scale = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Scale",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 24. BiologicallyDerivedProduct.storage.duration
                    this.Element_Duration = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Duration",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 1. BiologicallyDerivedProduct.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. BiologicallyDerivedProduct.productCategory
        public MakerElementInstance Element_ProductCategory;                                                                                // MakerGen.cs:232
        // 3. BiologicallyDerivedProduct.productCode
        public MakerElementInstance Element_ProductCode;                                                                                    // MakerGen.cs:232
        // 4. BiologicallyDerivedProduct.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 5. BiologicallyDerivedProduct.request
        public MakerElementInstance Element_Request;                                                                                        // MakerGen.cs:232
        // 6. BiologicallyDerivedProduct.quantity
        public MakerElementInstance Element_Quantity;                                                                                       // MakerGen.cs:232
        // 7. BiologicallyDerivedProduct.parent
        public MakerElementInstance Element_Parent;                                                                                         // MakerGen.cs:232
        public BiologicallyDerivedProduct()                                                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. BiologicallyDerivedProduct.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. BiologicallyDerivedProduct.productCategory
                this.Element_ProductCategory = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ProductCategory",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. BiologicallyDerivedProduct.productCode
                this.Element_ProductCode = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ProductCode",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 4. BiologicallyDerivedProduct.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 5. BiologicallyDerivedProduct.request
                this.Element_Request = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Request",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                    // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 6. BiologicallyDerivedProduct.quantity
                this.Element_Quantity = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Integer                                                                         // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 7. BiologicallyDerivedProduct.parent
                this.Element_Parent = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Parent",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct"                                        // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:430
