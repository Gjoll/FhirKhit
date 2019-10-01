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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'BiologicallyDerivedProduct'
    /// </summary>
    // 0. BiologicallyDerivedProduct
    public class BiologicallyDerivedProduct : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class BiologicallyDerivedProduct_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 8. BiologicallyDerivedProduct.collection
            public class Type_Collection : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Collection_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 9. BiologicallyDerivedProduct.collection.collector
                    public ElementDefinitionInfo Collector;                                                                                 // MakerGen.cs:236
                    // 10. BiologicallyDerivedProduct.collection.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:236
                    // 11. BiologicallyDerivedProduct.collection.collected[x]
                    public ElementDefinitionInfo Collected;                                                                                 // MakerGen.cs:236
                    public Type_Collection_Elements()                                                                                       // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. BiologicallyDerivedProduct.collection.collector
                            this.Collector = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Collector",                                                                                         // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.collection.collector",                                                    // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.collection.collector",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 10. BiologicallyDerivedProduct.collection.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Source",                                                                                            // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.collection.source",                                                       // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.collection.source",                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 11. BiologicallyDerivedProduct.collection.collected[x]
                            this.Collected = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Collected",                                                                                         // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.collection.collected[x]",                                                 // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.collection.collected[x]",                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Collector.Write(sDef);                                                                                              // MakerGen.cs:240
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Collected.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Collection_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Collection()                                                                                                    // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Collection_Elements();                                                                         // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 12. BiologicallyDerivedProduct.processing
            public class Type_Processing : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Processing_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 13. BiologicallyDerivedProduct.processing.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    // 14. BiologicallyDerivedProduct.processing.procedure
                    public ElementDefinitionInfo Procedure;                                                                                 // MakerGen.cs:236
                    // 15. BiologicallyDerivedProduct.processing.additive
                    public ElementDefinitionInfo Additive;                                                                                  // MakerGen.cs:236
                    // 16. BiologicallyDerivedProduct.processing.time[x]
                    public ElementDefinitionInfo Time;                                                                                      // MakerGen.cs:236
                    public Type_Processing_Elements()                                                                                       // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. BiologicallyDerivedProduct.processing.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.processing.description",                                                  // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.processing.description",                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. BiologicallyDerivedProduct.processing.procedure
                            this.Procedure = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Procedure",                                                                                         // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.processing.procedure",                                                    // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.processing.procedure",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
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
                            // 15. BiologicallyDerivedProduct.processing.additive
                            this.Additive = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Additive",                                                                                          // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.processing.additive",                                                     // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.processing.additive",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Substance"                                             // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. BiologicallyDerivedProduct.processing.time[x]
                            this.Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Time",                                                                                              // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.processing.time[x]",                                                      // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.processing.time[x]",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                        Procedure.Write(sDef);                                                                                              // MakerGen.cs:240
                        Additive.Write(sDef);                                                                                               // MakerGen.cs:240
                        Time.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Processing_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Processing()                                                                                                    // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Processing_Elements();                                                                         // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 17. BiologicallyDerivedProduct.manipulation
            public class Type_Manipulation : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Manipulation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 18. BiologicallyDerivedProduct.manipulation.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    // 19. BiologicallyDerivedProduct.manipulation.time[x]
                    public ElementDefinitionInfo Time;                                                                                      // MakerGen.cs:236
                    public Type_Manipulation_Elements()                                                                                     // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. BiologicallyDerivedProduct.manipulation.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.manipulation.description",                                                // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.manipulation.description",                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. BiologicallyDerivedProduct.manipulation.time[x]
                            this.Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Time",                                                                                              // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.manipulation.time[x]",                                                    // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.manipulation.time[x]",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                        Time.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Manipulation_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Manipulation()                                                                                                  // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Manipulation_Elements();                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 20. BiologicallyDerivedProduct.storage
            public class Type_Storage : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Storage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 21. BiologicallyDerivedProduct.storage.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    // 22. BiologicallyDerivedProduct.storage.temperature
                    public ElementDefinitionInfo Temperature;                                                                               // MakerGen.cs:236
                    // 23. BiologicallyDerivedProduct.storage.scale
                    public ElementDefinitionInfo Scale;                                                                                     // MakerGen.cs:236
                    // 24. BiologicallyDerivedProduct.storage.duration
                    public ElementDefinitionInfo Duration;                                                                                  // MakerGen.cs:236
                    public Type_Storage_Elements()                                                                                          // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 21. BiologicallyDerivedProduct.storage.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.storage.description",                                                     // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.storage.description",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 22. BiologicallyDerivedProduct.storage.temperature
                            this.Temperature = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Temperature",                                                                                       // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.storage.temperature",                                                     // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.storage.temperature",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 23. BiologicallyDerivedProduct.storage.scale
                            this.Scale = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Scale",                                                                                             // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.storage.scale",                                                           // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.storage.scale",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 24. BiologicallyDerivedProduct.storage.duration
                            this.Duration = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Duration",                                                                                          // MakerGen.cs:255
                                Path= "BiologicallyDerivedProduct.storage.duration",                                                        // MakerGen.cs:256
                                Id = "BiologicallyDerivedProduct.storage.duration",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                        Temperature.Write(sDef);                                                                                            // MakerGen.cs:240
                        Scale.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Duration.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Storage_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Storage()                                                                                                       // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Storage_Elements();                                                                            // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. BiologicallyDerivedProduct.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. BiologicallyDerivedProduct.productCategory
            public ElementDefinitionInfo ProductCategory;                                                                                   // MakerGen.cs:236
            // 3. BiologicallyDerivedProduct.productCode
            public ElementDefinitionInfo ProductCode;                                                                                       // MakerGen.cs:236
            // 4. BiologicallyDerivedProduct.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 5. BiologicallyDerivedProduct.request
            public ElementDefinitionInfo Request;                                                                                           // MakerGen.cs:236
            // 6. BiologicallyDerivedProduct.quantity
            public ElementDefinitionInfo Quantity;                                                                                          // MakerGen.cs:236
            // 7. BiologicallyDerivedProduct.parent
            public ElementDefinitionInfo Parent;                                                                                            // MakerGen.cs:236
            public BiologicallyDerivedProduct_Elements()                                                                                    // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. BiologicallyDerivedProduct.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "BiologicallyDerivedProduct.identifier",                                                                      // MakerGen.cs:256
                        Id = "BiologicallyDerivedProduct.identifier",                                                                       // MakerGen.cs:257
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
                    // 2. BiologicallyDerivedProduct.productCategory
                    this.ProductCategory = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ProductCategory",                                                                                           // MakerGen.cs:255
                        Path= "BiologicallyDerivedProduct.productCategory",                                                                 // MakerGen.cs:256
                        Id = "BiologicallyDerivedProduct.productCategory",                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. BiologicallyDerivedProduct.productCode
                    this.ProductCode = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ProductCode",                                                                                               // MakerGen.cs:255
                        Path= "BiologicallyDerivedProduct.productCode",                                                                     // MakerGen.cs:256
                        Id = "BiologicallyDerivedProduct.productCode",                                                                      // MakerGen.cs:257
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
                    // 4. BiologicallyDerivedProduct.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "BiologicallyDerivedProduct.status",                                                                          // MakerGen.cs:256
                        Id = "BiologicallyDerivedProduct.status",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. BiologicallyDerivedProduct.request
                    this.Request = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Request",                                                                                                   // MakerGen.cs:255
                        Path= "BiologicallyDerivedProduct.request",                                                                         // MakerGen.cs:256
                        Id = "BiologicallyDerivedProduct.request",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. BiologicallyDerivedProduct.quantity
                    this.Quantity = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Quantity",                                                                                                  // MakerGen.cs:255
                        Path= "BiologicallyDerivedProduct.quantity",                                                                        // MakerGen.cs:256
                        Id = "BiologicallyDerivedProduct.quantity",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. BiologicallyDerivedProduct.parent
                    this.Parent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Parent",                                                                                                    // MakerGen.cs:255
                        Path= "BiologicallyDerivedProduct.parent",                                                                          // MakerGen.cs:256
                        Id = "BiologicallyDerivedProduct.parent",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct"                                    // MakerGen.cs:348
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
                ProductCategory.Write(sDef);                                                                                                // MakerGen.cs:240
                ProductCode.Write(sDef);                                                                                                    // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Request.Write(sDef);                                                                                                        // MakerGen.cs:240
                Quantity.Write(sDef);                                                                                                       // MakerGen.cs:240
                Parent.Write(sDef);                                                                                                         // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public BiologicallyDerivedProduct_Elements Elements { get; }                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public BiologicallyDerivedProduct()                                                                                                 // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new BiologicallyDerivedProduct_Elements();                                                                      // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
