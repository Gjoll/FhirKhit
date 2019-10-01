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
      "id": "CatalogEntry",
      "url": "http://hl7.org/fhir/StructureDefinition/CatalogEntry",
      "version": "4.0.0",
      "name": "CatalogEntry",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "Catalog entries are wrappers that contextualize items included in a catalog.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CatalogEntry",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "CatalogEntry",
            "path": "CatalogEntry",
            "short": "An entry in a catalog",
            "definition": "Catalog entries are wrappers that contextualize items included in a catalog.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CatalogEntry.identifier",
            "path": "CatalogEntry.identifier",
            "short": "Unique identifier of the catalog item",
            "definition": "Used in supporting different identifiers for the same product, e.g. manufacturer code and retailer code.",
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
            "id": "CatalogEntry.type",
            "path": "CatalogEntry.type",
            "short": "The type of item - medication, device, service, protocol or other",
            "definition": "The type of item - medication, device, service, protocol or other.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CatalogEntry.orderable",
            "path": "CatalogEntry.orderable",
            "short": "Whether the entry represents an orderable item",
            "definition": "Whether the entry represents an orderable item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CatalogEntry.referencedItem",
            "path": "CatalogEntry.referencedItem",
            "short": "The item that is being defined",
            "definition": "The item in a catalog or definition.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition",
                  "http://hl7.org/fhir/StructureDefinition/ObservationDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Binary"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CatalogEntry.additionalIdentifier",
            "path": "CatalogEntry.additionalIdentifier",
            "short": "Any additional identifier(s) for the catalog item, in the same granularity or concept",
            "definition": "Used in supporting related concepts, e.g. NDC to RxNorm.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "CatalogEntry.classification",
            "path": "CatalogEntry.classification",
            "short": "Classification (category or class) of the item entry",
            "definition": "Classes of devices, or ATC for medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CatalogEntry.status",
            "path": "CatalogEntry.status",
            "short": "draft | active | retired | unknown",
            "definition": "Used to support catalog exchange even for unsupported products, e.g. getting list of medications even if not prescribable.",
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
                  "valueString": "PublicationStatus"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The lifecycle status of an artifact.",
              "valueSet": "http://hl7.org/fhir/ValueSet/publication-status|4.0.0"
            }
          },
          {
            "id": "CatalogEntry.validityPeriod",
            "path": "CatalogEntry.validityPeriod",
            "short": "The time period in which this catalog entry is expected to be active",
            "definition": "The time period in which this catalog entry is expected to be active.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "CatalogEntry.validTo",
            "path": "CatalogEntry.validTo",
            "short": "The date until which this catalog entry is expected to be active",
            "definition": "The date until which this catalog entry is expected to be active.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "CatalogEntry.lastUpdated",
            "path": "CatalogEntry.lastUpdated",
            "short": "When was this catalog last updated",
            "definition": "Typically date of issue is different from the beginning of the validity. This can be used to see when an item was last updated.",
            "comment": "Perhaps not needed - if we use fhir resource metadata.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "CatalogEntry.additionalCharacteristic",
            "path": "CatalogEntry.additionalCharacteristic",
            "short": "Additional characteristics of the catalog entry",
            "definition": "Used for examplefor Out of Formulary, or any specifics.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CatalogEntry.additionalClassification",
            "path": "CatalogEntry.additionalClassification",
            "short": "Additional classification of the catalog entry",
            "definition": "User for example for ATC classification, or.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CatalogEntry.relatedEntry",
            "path": "CatalogEntry.relatedEntry",
            "short": "An item that this catalog entry is related to",
            "definition": "Used for example, to point to a substance, or to a device used to administer a medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CatalogEntry.relatedEntry.relationtype",
            "path": "CatalogEntry.relatedEntry.relationtype",
            "short": "triggers | is-replaced-by",
            "definition": "The type of relation to the related item: child, parent, packageContent, containerPackage, usedIn, uses, requires, etc.",
            "min": 1,
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
                  "valueString": "CatalogEntryRelationType"
                }
              ],
              "strength": "required",
              "description": "The type of relations between entries.",
              "valueSet": "http://hl7.org/fhir/ValueSet/relation-type|4.0.0"
            }
          },
          {
            "id": "CatalogEntry.relatedEntry.item",
            "path": "CatalogEntry.relatedEntry.item",
            "short": "The reference to the related item",
            "definition": "The reference to the related item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CatalogEntry"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'CatalogEntry'
    /// </summary>
    // 0. CatalogEntry
    public class CatalogEntry : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class CatalogEntry_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 13. CatalogEntry.relatedEntry
            public class Type_RelatedEntry : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_RelatedEntry_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 14. CatalogEntry.relatedEntry.relationtype
                    public ElementDefinitionInfo Relationtype;                                                                              // MakerGen.cs:236
                    // 15. CatalogEntry.relatedEntry.item
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:236
                    public Type_RelatedEntry_Elements()                                                                                     // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. CatalogEntry.relatedEntry.relationtype
                            this.Relationtype = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Relationtype",                                                                                      // MakerGen.cs:255
                                Path= "CatalogEntry.relatedEntry.relationtype",                                                             // MakerGen.cs:256
                                Id = "CatalogEntry.relatedEntry.relationtype",                                                              // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
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
                            // 15. CatalogEntry.relatedEntry.item
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Item",                                                                                              // MakerGen.cs:255
                                Path= "CatalogEntry.relatedEntry.item",                                                                     // MakerGen.cs:256
                                Id = "CatalogEntry.relatedEntry.item",                                                                      // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/CatalogEntry"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Relationtype.Write(sDef);                                                                                           // MakerGen.cs:240
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_RelatedEntry_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_RelatedEntry()                                                                                                  // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_RelatedEntry_Elements();                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. CatalogEntry.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. CatalogEntry.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:236
            // 3. CatalogEntry.orderable
            public ElementDefinitionInfo Orderable;                                                                                         // MakerGen.cs:236
            // 4. CatalogEntry.referencedItem
            public ElementDefinitionInfo ReferencedItem;                                                                                    // MakerGen.cs:236
            // 5. CatalogEntry.additionalIdentifier
            public ElementDefinitionInfo AdditionalIdentifier;                                                                              // MakerGen.cs:236
            // 6. CatalogEntry.classification
            public ElementDefinitionInfo Classification;                                                                                    // MakerGen.cs:236
            // 7. CatalogEntry.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 8. CatalogEntry.validityPeriod
            public ElementDefinitionInfo ValidityPeriod;                                                                                    // MakerGen.cs:236
            // 9. CatalogEntry.validTo
            public ElementDefinitionInfo ValidTo;                                                                                           // MakerGen.cs:236
            // 10. CatalogEntry.lastUpdated
            public ElementDefinitionInfo LastUpdated;                                                                                       // MakerGen.cs:236
            // 11. CatalogEntry.additionalCharacteristic
            public ElementDefinitionInfo AdditionalCharacteristic;                                                                          // MakerGen.cs:236
            // 12. CatalogEntry.additionalClassification
            public ElementDefinitionInfo AdditionalClassification;                                                                          // MakerGen.cs:236
            public CatalogEntry_Elements()                                                                                                  // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. CatalogEntry.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "CatalogEntry.identifier",                                                                                    // MakerGen.cs:256
                        Id = "CatalogEntry.identifier",                                                                                     // MakerGen.cs:257
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
                    // 2. CatalogEntry.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Type",                                                                                                      // MakerGen.cs:255
                        Path= "CatalogEntry.type",                                                                                          // MakerGen.cs:256
                        Id = "CatalogEntry.type",                                                                                           // MakerGen.cs:257
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
                    // 3. CatalogEntry.orderable
                    this.Orderable = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Orderable",                                                                                                 // MakerGen.cs:255
                        Path= "CatalogEntry.orderable",                                                                                     // MakerGen.cs:256
                        Id = "CatalogEntry.orderable",                                                                                      // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. CatalogEntry.referencedItem
                    this.ReferencedItem = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReferencedItem",                                                                                            // MakerGen.cs:255
                        Path= "CatalogEntry.referencedItem",                                                                                // MakerGen.cs:256
                        Id = "CatalogEntry.referencedItem",                                                                                 // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                            // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                           // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                               // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition",                                           // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ObservationDefinition",                                        // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Binary"                                                        // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. CatalogEntry.additionalIdentifier
                    this.AdditionalIdentifier = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AdditionalIdentifier",                                                                                      // MakerGen.cs:255
                        Path= "CatalogEntry.additionalIdentifier",                                                                          // MakerGen.cs:256
                        Id = "CatalogEntry.additionalIdentifier",                                                                           // MakerGen.cs:257
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
                    // 6. CatalogEntry.classification
                    this.Classification = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Classification",                                                                                            // MakerGen.cs:255
                        Path= "CatalogEntry.classification",                                                                                // MakerGen.cs:256
                        Id = "CatalogEntry.classification",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. CatalogEntry.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "CatalogEntry.status",                                                                                        // MakerGen.cs:256
                        Id = "CatalogEntry.status",                                                                                         // MakerGen.cs:257
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
                    // 8. CatalogEntry.validityPeriod
                    this.ValidityPeriod = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ValidityPeriod",                                                                                            // MakerGen.cs:255
                        Path= "CatalogEntry.validityPeriod",                                                                                // MakerGen.cs:256
                        Id = "CatalogEntry.validityPeriod",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. CatalogEntry.validTo
                    this.ValidTo = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ValidTo",                                                                                                   // MakerGen.cs:255
                        Path= "CatalogEntry.validTo",                                                                                       // MakerGen.cs:256
                        Id = "CatalogEntry.validTo",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. CatalogEntry.lastUpdated
                    this.LastUpdated = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "LastUpdated",                                                                                               // MakerGen.cs:255
                        Path= "CatalogEntry.lastUpdated",                                                                                   // MakerGen.cs:256
                        Id = "CatalogEntry.lastUpdated",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. CatalogEntry.additionalCharacteristic
                    this.AdditionalCharacteristic = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AdditionalCharacteristic",                                                                                  // MakerGen.cs:255
                        Path= "CatalogEntry.additionalCharacteristic",                                                                      // MakerGen.cs:256
                        Id = "CatalogEntry.additionalCharacteristic",                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 12. CatalogEntry.additionalClassification
                    this.AdditionalClassification = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AdditionalClassification",                                                                                  // MakerGen.cs:255
                        Path= "CatalogEntry.additionalClassification",                                                                      // MakerGen.cs:256
                        Id = "CatalogEntry.additionalClassification",                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Type.Write(sDef);                                                                                                           // MakerGen.cs:240
                Orderable.Write(sDef);                                                                                                      // MakerGen.cs:240
                ReferencedItem.Write(sDef);                                                                                                 // MakerGen.cs:240
                AdditionalIdentifier.Write(sDef);                                                                                           // MakerGen.cs:240
                Classification.Write(sDef);                                                                                                 // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                ValidityPeriod.Write(sDef);                                                                                                 // MakerGen.cs:240
                ValidTo.Write(sDef);                                                                                                        // MakerGen.cs:240
                LastUpdated.Write(sDef);                                                                                                    // MakerGen.cs:240
                AdditionalCharacteristic.Write(sDef);                                                                                       // MakerGen.cs:240
                AdditionalClassification.Write(sDef);                                                                                       // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public CatalogEntry_Elements Elements { get; }                                                                                      // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public CatalogEntry()                                                                                                               // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new CatalogEntry_Elements();                                                                                    // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
