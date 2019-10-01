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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'BiologicallyDerivedProduct'
    /// </summary>
    // 0. BiologicallyDerivedProduct
    public class BiologicallyDerivedProduct : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class BiologicallyDerivedProduct_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 8. BiologicallyDerivedProduct.collection
            public class Type_Collection : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Collection_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 9. BiologicallyDerivedProduct.collection.collector
                    public ElementDefinitionInfo Collector;                                                                                 // MakerGen.cs:211
                    // 10. BiologicallyDerivedProduct.collection.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:211
                    // 11. BiologicallyDerivedProduct.collection.collected[x]
                    public ElementDefinitionInfo Collected;                                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Collection_Elements()                                                                                       // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. BiologicallyDerivedProduct.collection.collector
                            this.Collector = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Collector",                                                                                         // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.collection.collector",                                                    // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.collection.collector",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. BiologicallyDerivedProduct.collection.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Source",                                                                                            // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.collection.source",                                                       // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.collection.source",                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. BiologicallyDerivedProduct.collection.collected[x]
                            this.Collected = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Collected",                                                                                         // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.collection.collected[x]",                                                 // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.collection.collected[x]",                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Collector.Write(sDef);                                                                                              // MakerGen.cs:215
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Collected.Write(sDef);                                                                                              // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Collection_Elements Elements                                                                                    // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Collection_Elements();                                                                 // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Collection_Elements elements;                                                                                          // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Collection()                                                                                                    // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "BiologicallyDerivedProduct.collection",                                                                     // MakerGen.cs:423
                        ElementId = "BiologicallyDerivedProduct.collection"                                                                 // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 12. BiologicallyDerivedProduct.processing
            public class Type_Processing : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Processing_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 13. BiologicallyDerivedProduct.processing.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 14. BiologicallyDerivedProduct.processing.procedure
                    public ElementDefinitionInfo Procedure;                                                                                 // MakerGen.cs:211
                    // 15. BiologicallyDerivedProduct.processing.additive
                    public ElementDefinitionInfo Additive;                                                                                  // MakerGen.cs:211
                    // 16. BiologicallyDerivedProduct.processing.time[x]
                    public ElementDefinitionInfo Time;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Processing_Elements()                                                                                       // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. BiologicallyDerivedProduct.processing.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.processing.description",                                                  // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.processing.description",                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. BiologicallyDerivedProduct.processing.procedure
                            this.Procedure = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Procedure",                                                                                         // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.processing.procedure",                                                    // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.processing.procedure",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 15. BiologicallyDerivedProduct.processing.additive
                            this.Additive = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Additive",                                                                                          // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.processing.additive",                                                     // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.processing.additive",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Substance"                                             // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. BiologicallyDerivedProduct.processing.time[x]
                            this.Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Time",                                                                                              // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.processing.time[x]",                                                      // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.processing.time[x]",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        Procedure.Write(sDef);                                                                                              // MakerGen.cs:215
                        Additive.Write(sDef);                                                                                               // MakerGen.cs:215
                        Time.Write(sDef);                                                                                                   // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Processing_Elements Elements                                                                                    // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Processing_Elements();                                                                 // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Processing_Elements elements;                                                                                          // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Processing()                                                                                                    // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "BiologicallyDerivedProduct.processing",                                                                     // MakerGen.cs:423
                        ElementId = "BiologicallyDerivedProduct.processing"                                                                 // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 17. BiologicallyDerivedProduct.manipulation
            public class Type_Manipulation : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Manipulation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 18. BiologicallyDerivedProduct.manipulation.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 19. BiologicallyDerivedProduct.manipulation.time[x]
                    public ElementDefinitionInfo Time;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Manipulation_Elements()                                                                                     // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. BiologicallyDerivedProduct.manipulation.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.manipulation.description",                                                // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.manipulation.description",                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 19. BiologicallyDerivedProduct.manipulation.time[x]
                            this.Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Time",                                                                                              // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.manipulation.time[x]",                                                    // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.manipulation.time[x]",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        Time.Write(sDef);                                                                                                   // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Manipulation_Elements Elements                                                                                  // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Manipulation_Elements();                                                               // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Manipulation_Elements elements;                                                                                        // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Manipulation()                                                                                                  // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "BiologicallyDerivedProduct.manipulation",                                                                   // MakerGen.cs:423
                        ElementId = "BiologicallyDerivedProduct.manipulation"                                                               // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 20. BiologicallyDerivedProduct.storage
            public class Type_Storage : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Storage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 21. BiologicallyDerivedProduct.storage.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 22. BiologicallyDerivedProduct.storage.temperature
                    public ElementDefinitionInfo Temperature;                                                                               // MakerGen.cs:211
                    // 23. BiologicallyDerivedProduct.storage.scale
                    public ElementDefinitionInfo Scale;                                                                                     // MakerGen.cs:211
                    // 24. BiologicallyDerivedProduct.storage.duration
                    public ElementDefinitionInfo Duration;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Storage_Elements()                                                                                          // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 21. BiologicallyDerivedProduct.storage.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.storage.description",                                                     // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.storage.description",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 22. BiologicallyDerivedProduct.storage.temperature
                            this.Temperature = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Temperature",                                                                                       // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.storage.temperature",                                                     // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.storage.temperature",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. BiologicallyDerivedProduct.storage.scale
                            this.Scale = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Scale",                                                                                             // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.storage.scale",                                                           // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.storage.scale",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. BiologicallyDerivedProduct.storage.duration
                            this.Duration = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Duration",                                                                                          // MakerGen.cs:230
                                Path= "BiologicallyDerivedProduct.storage.duration",                                                        // MakerGen.cs:231
                                Id = "BiologicallyDerivedProduct.storage.duration",                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        Temperature.Write(sDef);                                                                                            // MakerGen.cs:215
                        Scale.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Duration.Write(sDef);                                                                                               // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Storage_Elements Elements                                                                                       // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Storage_Elements();                                                                    // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Storage_Elements elements;                                                                                             // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Storage()                                                                                                       // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "BiologicallyDerivedProduct.storage",                                                                        // MakerGen.cs:423
                        ElementId = "BiologicallyDerivedProduct.storage"                                                                    // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. BiologicallyDerivedProduct.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. BiologicallyDerivedProduct.productCategory
            public ElementDefinitionInfo ProductCategory;                                                                                   // MakerGen.cs:211
            // 3. BiologicallyDerivedProduct.productCode
            public ElementDefinitionInfo ProductCode;                                                                                       // MakerGen.cs:211
            // 4. BiologicallyDerivedProduct.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 5. BiologicallyDerivedProduct.request
            public ElementDefinitionInfo Request;                                                                                           // MakerGen.cs:211
            // 6. BiologicallyDerivedProduct.quantity
            public ElementDefinitionInfo Quantity;                                                                                          // MakerGen.cs:211
            // 7. BiologicallyDerivedProduct.parent
            public ElementDefinitionInfo Parent;                                                                                            // MakerGen.cs:211
            // 8. BiologicallyDerivedProduct.collection
            public ElementDefinitionInfo Collection;                                                                                        // MakerGen.cs:211
            // 12. BiologicallyDerivedProduct.processing
            public ElementDefinitionInfo Processing;                                                                                        // MakerGen.cs:211
            // 17. BiologicallyDerivedProduct.manipulation
            public ElementDefinitionInfo Manipulation;                                                                                      // MakerGen.cs:211
            // 20. BiologicallyDerivedProduct.storage
            public ElementDefinitionInfo Storage;                                                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public BiologicallyDerivedProduct_Elements()                                                                                    // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. BiologicallyDerivedProduct.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.identifier",                                                                      // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.identifier",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. BiologicallyDerivedProduct.productCategory
                    this.ProductCategory = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ProductCategory",                                                                                           // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.productCategory",                                                                 // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.productCategory",                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. BiologicallyDerivedProduct.productCode
                    this.ProductCode = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ProductCode",                                                                                               // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.productCode",                                                                     // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.productCode",                                                                      // MakerGen.cs:232
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
                    // 4. BiologicallyDerivedProduct.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.status",                                                                          // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.status",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. BiologicallyDerivedProduct.request
                    this.Request = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Request",                                                                                                   // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.request",                                                                         // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.request",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. BiologicallyDerivedProduct.quantity
                    this.Quantity = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Quantity",                                                                                                  // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.quantity",                                                                        // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.quantity",                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. BiologicallyDerivedProduct.parent
                    this.Parent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Parent",                                                                                                    // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.parent",                                                                          // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.parent",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct"                                    // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. BiologicallyDerivedProduct.collection
                    this.Collection = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Collection",                                                                                                // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.collection",                                                                      // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.collection",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Collection                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. BiologicallyDerivedProduct.processing
                    this.Processing = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Processing",                                                                                                // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.processing",                                                                      // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.processing",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Processing                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. BiologicallyDerivedProduct.manipulation
                    this.Manipulation = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Manipulation",                                                                                              // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.manipulation",                                                                    // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.manipulation",                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Manipulation                                                                                           // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. BiologicallyDerivedProduct.storage
                    this.Storage = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Storage",                                                                                                   // MakerGen.cs:230
                        Path= "BiologicallyDerivedProduct.storage",                                                                         // MakerGen.cs:231
                        Id = "BiologicallyDerivedProduct.storage",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Storage                                                                                                // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                ProductCategory.Write(sDef);                                                                                                // MakerGen.cs:215
                ProductCode.Write(sDef);                                                                                                    // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Request.Write(sDef);                                                                                                        // MakerGen.cs:215
                Quantity.Write(sDef);                                                                                                       // MakerGen.cs:215
                Parent.Write(sDef);                                                                                                         // MakerGen.cs:215
                Collection.Write(sDef);                                                                                                     // MakerGen.cs:215
                Processing.Write(sDef);                                                                                                     // MakerGen.cs:215
                Manipulation.Write(sDef);                                                                                                   // MakerGen.cs:215
                Storage.Write(sDef);                                                                                                        // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public BiologicallyDerivedProduct_Elements Elements                                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new BiologicallyDerivedProduct_Elements();                                                              // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        BiologicallyDerivedProduct_Elements elements;                                                                                       // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public BiologicallyDerivedProduct()                                                                                                 // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "BiologicallyDerivedProduct";                                                                                       // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct";                                                // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "BiologicallyDerivedProduct",                                                                                        // MakerGen.cs:423
                ElementId = "BiologicallyDerivedProduct"                                                                                    // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
