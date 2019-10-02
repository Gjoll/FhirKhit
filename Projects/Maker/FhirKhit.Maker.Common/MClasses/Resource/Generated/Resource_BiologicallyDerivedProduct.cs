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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'BiologicallyDerivedProduct'
    /// </summary>
    // 0. BiologicallyDerivedProduct
    public class Resource_BiologicallyDerivedProduct : FhirKhit.Maker.Common.Resource.Resource_DomainResource                               // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 8. BiologicallyDerivedProduct.collection
        public class Type_Collection : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 9. BiologicallyDerivedProduct.collection.collector
            public ElementDefinitionInfo Element_Collector;                                                                                 // MakerGen.cs:219
            // 10. BiologicallyDerivedProduct.collection.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:219
            // 11. BiologicallyDerivedProduct.collection.collected[x]
            public ElementDefinitionInfo Element_Collected;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "BiologicallyDerivedProduct.collection",                                                                         // MakerGen.cs:395
                    ElementId = "BiologicallyDerivedProduct.collection"                                                                     // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Collector.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Collected.Write(sDef);                                                                                              // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Collection()                                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 9. BiologicallyDerivedProduct.collection.collector
                    this.Element_Collector = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Collector",                                                                                         // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.collection.collector",                                                            // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.collection.collector",                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 10. BiologicallyDerivedProduct.collection.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Source",                                                                                            // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.collection.source",                                                               // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.collection.source",                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 11. BiologicallyDerivedProduct.collection.collected[x]
                    this.Element_Collected = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Collected",                                                                                         // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.collection.collected[x]",                                                         // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.collection.collected[x]",                                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            },                                                                                                              // MakerGen.cs:307
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 12. BiologicallyDerivedProduct.processing
        public class Type_Processing : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 13. BiologicallyDerivedProduct.processing.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:219
            // 14. BiologicallyDerivedProduct.processing.procedure
            public ElementDefinitionInfo Element_Procedure;                                                                                 // MakerGen.cs:219
            // 15. BiologicallyDerivedProduct.processing.additive
            public ElementDefinitionInfo Element_Additive;                                                                                  // MakerGen.cs:219
            // 16. BiologicallyDerivedProduct.processing.time[x]
            public ElementDefinitionInfo Element_Time;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "BiologicallyDerivedProduct.processing",                                                                         // MakerGen.cs:395
                    ElementId = "BiologicallyDerivedProduct.processing"                                                                     // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Procedure.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Additive.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Time.Write(sDef);                                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Processing()                                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 13. BiologicallyDerivedProduct.processing.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Description",                                                                                       // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.processing.description",                                                          // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.processing.description",                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. BiologicallyDerivedProduct.processing.procedure
                    this.Element_Procedure = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Procedure",                                                                                         // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.processing.procedure",                                                            // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.processing.procedure",                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
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
                    // 15. BiologicallyDerivedProduct.processing.additive
                    this.Element_Additive = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Additive",                                                                                          // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.processing.additive",                                                             // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.processing.additive",                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. BiologicallyDerivedProduct.processing.time[x]
                    this.Element_Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Time",                                                                                              // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.processing.time[x]",                                                              // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.processing.time[x]",                                                               // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            },                                                                                                              // MakerGen.cs:307
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 17. BiologicallyDerivedProduct.manipulation
        public class Type_Manipulation : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 18. BiologicallyDerivedProduct.manipulation.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:219
            // 19. BiologicallyDerivedProduct.manipulation.time[x]
            public ElementDefinitionInfo Element_Time;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "BiologicallyDerivedProduct.manipulation",                                                                       // MakerGen.cs:395
                    ElementId = "BiologicallyDerivedProduct.manipulation"                                                                   // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Time.Write(sDef);                                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Manipulation()                                                                                                      // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 18. BiologicallyDerivedProduct.manipulation.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Description",                                                                                       // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.manipulation.description",                                                        // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.manipulation.description",                                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 19. BiologicallyDerivedProduct.manipulation.time[x]
                    this.Element_Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Time",                                                                                              // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.manipulation.time[x]",                                                            // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.manipulation.time[x]",                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            },                                                                                                              // MakerGen.cs:307
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 20. BiologicallyDerivedProduct.storage
        public class Type_Storage : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 21. BiologicallyDerivedProduct.storage.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:219
            // 22. BiologicallyDerivedProduct.storage.temperature
            public ElementDefinitionInfo Element_Temperature;                                                                               // MakerGen.cs:219
            // 23. BiologicallyDerivedProduct.storage.scale
            public ElementDefinitionInfo Element_Scale;                                                                                     // MakerGen.cs:219
            // 24. BiologicallyDerivedProduct.storage.duration
            public ElementDefinitionInfo Element_Duration;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "BiologicallyDerivedProduct.storage",                                                                            // MakerGen.cs:395
                    ElementId = "BiologicallyDerivedProduct.storage"                                                                        // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Temperature.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Scale.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Duration.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Storage()                                                                                                           // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 21. BiologicallyDerivedProduct.storage.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Description",                                                                                       // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.storage.description",                                                             // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.storage.description",                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 22. BiologicallyDerivedProduct.storage.temperature
                    this.Element_Temperature = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Temperature",                                                                                       // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.storage.temperature",                                                             // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.storage.temperature",                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 23. BiologicallyDerivedProduct.storage.scale
                    this.Element_Scale = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Scale",                                                                                             // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.storage.scale",                                                                   // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.storage.scale",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 24. BiologicallyDerivedProduct.storage.duration
                    this.Element_Duration = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Duration",                                                                                          // MakerGen.cs:238
                        Path= "BiologicallyDerivedProduct.storage.duration",                                                                // MakerGen.cs:239
                        Id = "BiologicallyDerivedProduct.storage.duration",                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. BiologicallyDerivedProduct.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. BiologicallyDerivedProduct.productCategory
        public ElementDefinitionInfo Element_ProductCategory;                                                                               // MakerGen.cs:219
        // 3. BiologicallyDerivedProduct.productCode
        public ElementDefinitionInfo Element_ProductCode;                                                                                   // MakerGen.cs:219
        // 4. BiologicallyDerivedProduct.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 5. BiologicallyDerivedProduct.request
        public ElementDefinitionInfo Element_Request;                                                                                       // MakerGen.cs:219
        // 6. BiologicallyDerivedProduct.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:219
        // 7. BiologicallyDerivedProduct.parent
        public ElementDefinitionInfo Element_Parent;                                                                                        // MakerGen.cs:219
        // 8. BiologicallyDerivedProduct.collection
        public ElementDefinitionInfo Element_Collection;                                                                                    // MakerGen.cs:219
        // 12. BiologicallyDerivedProduct.processing
        public ElementDefinitionInfo Element_Processing;                                                                                    // MakerGen.cs:219
        // 17. BiologicallyDerivedProduct.manipulation
        public ElementDefinitionInfo Element_Manipulation;                                                                                  // MakerGen.cs:219
        // 20. BiologicallyDerivedProduct.storage
        public ElementDefinitionInfo Element_Storage;                                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "BiologicallyDerivedProduct",                                                                                        // MakerGen.cs:395
                ElementId = "BiologicallyDerivedProduct"                                                                                    // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_ProductCategory.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_ProductCode.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Request.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Parent.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Collection.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Processing.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Manipulation.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Storage.Write(sDef);                                                                                                    // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_BiologicallyDerivedProduct()                                                                                        // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. BiologicallyDerivedProduct.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.identifier",                                                                          // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.identifier",                                                                           // MakerGen.cs:240
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
                // 2. BiologicallyDerivedProduct.productCategory
                this.Element_ProductCategory = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ProductCategory",                                                                                       // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.productCategory",                                                                     // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.productCategory",                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. BiologicallyDerivedProduct.productCode
                this.Element_ProductCode = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ProductCode",                                                                                           // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.productCode",                                                                         // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.productCode",                                                                          // MakerGen.cs:240
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
                // 4. BiologicallyDerivedProduct.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.status",                                                                              // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.status",                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. BiologicallyDerivedProduct.request
                this.Element_Request = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Request",                                                                                               // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.request",                                                                             // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.request",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                    // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. BiologicallyDerivedProduct.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.quantity",                                                                            // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.quantity",                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. BiologicallyDerivedProduct.parent
                this.Element_Parent = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Parent",                                                                                                // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.parent",                                                                              // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.parent",                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct"                                        // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. BiologicallyDerivedProduct.collection
                this.Element_Collection = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Collection",                                                                                            // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.collection",                                                                          // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.collection",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Collection                                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. BiologicallyDerivedProduct.processing
                this.Element_Processing = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Processing",                                                                                            // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.processing",                                                                          // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.processing",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Processing                                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 17. BiologicallyDerivedProduct.manipulation
                this.Element_Manipulation = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Manipulation",                                                                                          // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.manipulation",                                                                        // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.manipulation",                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Manipulation                                                                                               // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 20. BiologicallyDerivedProduct.storage
                this.Element_Storage = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Storage",                                                                                               // MakerGen.cs:238
                    Path= "BiologicallyDerivedProduct.storage",                                                                             // MakerGen.cs:239
                    Id = "BiologicallyDerivedProduct.storage",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Storage                                                                                                    // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "BiologicallyDerivedProduct";                                                                                       // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct";                                                // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
