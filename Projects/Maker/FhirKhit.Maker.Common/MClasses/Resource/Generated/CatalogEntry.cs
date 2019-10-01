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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'CatalogEntry'
    /// </summary>
    // 0. CatalogEntry
    public class CatalogEntry : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class CatalogEntry_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 13. CatalogEntry.relatedEntry
            public class Type_RelatedEntry : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_RelatedEntry_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 14. CatalogEntry.relatedEntry.relationtype
                    public ElementDefinitionInfo Relationtype;                                                                              // MakerGen.cs:216
                    // 15. CatalogEntry.relatedEntry.item
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:216
                    public Type_RelatedEntry_Elements()                                                                                     // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. CatalogEntry.relatedEntry.relationtype
                            this.Relationtype = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Relationtype",                                                                                      // MakerGen.cs:235
                                Path= "CatalogEntry.relatedEntry.relationtype",                                                             // MakerGen.cs:236
                                Id = "CatalogEntry.relatedEntry.relationtype",                                                              // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. CatalogEntry.relatedEntry.item
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Item",                                                                                              // MakerGen.cs:235
                                Path= "CatalogEntry.relatedEntry.item",                                                                     // MakerGen.cs:236
                                Id = "CatalogEntry.relatedEntry.item",                                                                      // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/CatalogEntry"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Relationtype.Write(sDef);                                                                                           // MakerGen.cs:220
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_RelatedEntry_Elements Elements { get; }                                                                         // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_RelatedEntry()                                                                                                  // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_RelatedEntry_Elements();                                                                       // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. CatalogEntry.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. CatalogEntry.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 3. CatalogEntry.orderable
            public ElementDefinitionInfo Orderable;                                                                                         // MakerGen.cs:216
            // 4. CatalogEntry.referencedItem
            public ElementDefinitionInfo ReferencedItem;                                                                                    // MakerGen.cs:216
            // 5. CatalogEntry.additionalIdentifier
            public ElementDefinitionInfo AdditionalIdentifier;                                                                              // MakerGen.cs:216
            // 6. CatalogEntry.classification
            public ElementDefinitionInfo Classification;                                                                                    // MakerGen.cs:216
            // 7. CatalogEntry.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 8. CatalogEntry.validityPeriod
            public ElementDefinitionInfo ValidityPeriod;                                                                                    // MakerGen.cs:216
            // 9. CatalogEntry.validTo
            public ElementDefinitionInfo ValidTo;                                                                                           // MakerGen.cs:216
            // 10. CatalogEntry.lastUpdated
            public ElementDefinitionInfo LastUpdated;                                                                                       // MakerGen.cs:216
            // 11. CatalogEntry.additionalCharacteristic
            public ElementDefinitionInfo AdditionalCharacteristic;                                                                          // MakerGen.cs:216
            // 12. CatalogEntry.additionalClassification
            public ElementDefinitionInfo AdditionalClassification;                                                                          // MakerGen.cs:216
            // 13. CatalogEntry.relatedEntry
            public ElementDefinitionInfo RelatedEntry;                                                                                      // MakerGen.cs:216
            public CatalogEntry_Elements()                                                                                                  // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. CatalogEntry.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "CatalogEntry.identifier",                                                                                    // MakerGen.cs:236
                        Id = "CatalogEntry.identifier",                                                                                     // MakerGen.cs:237
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
                    // 2. CatalogEntry.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "CatalogEntry.type",                                                                                          // MakerGen.cs:236
                        Id = "CatalogEntry.type",                                                                                           // MakerGen.cs:237
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
                    // 3. CatalogEntry.orderable
                    this.Orderable = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Orderable",                                                                                                 // MakerGen.cs:235
                        Path= "CatalogEntry.orderable",                                                                                     // MakerGen.cs:236
                        Id = "CatalogEntry.orderable",                                                                                      // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. CatalogEntry.referencedItem
                    this.ReferencedItem = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReferencedItem",                                                                                            // MakerGen.cs:235
                        Path= "CatalogEntry.referencedItem",                                                                                // MakerGen.cs:236
                        Id = "CatalogEntry.referencedItem",                                                                                 // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                            // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                           // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                               // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition",                                           // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/ObservationDefinition",                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Binary"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. CatalogEntry.additionalIdentifier
                    this.AdditionalIdentifier = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AdditionalIdentifier",                                                                                      // MakerGen.cs:235
                        Path= "CatalogEntry.additionalIdentifier",                                                                          // MakerGen.cs:236
                        Id = "CatalogEntry.additionalIdentifier",                                                                           // MakerGen.cs:237
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
                    // 6. CatalogEntry.classification
                    this.Classification = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Classification",                                                                                            // MakerGen.cs:235
                        Path= "CatalogEntry.classification",                                                                                // MakerGen.cs:236
                        Id = "CatalogEntry.classification",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. CatalogEntry.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "CatalogEntry.status",                                                                                        // MakerGen.cs:236
                        Id = "CatalogEntry.status",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. CatalogEntry.validityPeriod
                    this.ValidityPeriod = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ValidityPeriod",                                                                                            // MakerGen.cs:235
                        Path= "CatalogEntry.validityPeriod",                                                                                // MakerGen.cs:236
                        Id = "CatalogEntry.validityPeriod",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. CatalogEntry.validTo
                    this.ValidTo = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ValidTo",                                                                                                   // MakerGen.cs:235
                        Path= "CatalogEntry.validTo",                                                                                       // MakerGen.cs:236
                        Id = "CatalogEntry.validTo",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. CatalogEntry.lastUpdated
                    this.LastUpdated = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LastUpdated",                                                                                               // MakerGen.cs:235
                        Path= "CatalogEntry.lastUpdated",                                                                                   // MakerGen.cs:236
                        Id = "CatalogEntry.lastUpdated",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. CatalogEntry.additionalCharacteristic
                    this.AdditionalCharacteristic = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AdditionalCharacteristic",                                                                                  // MakerGen.cs:235
                        Path= "CatalogEntry.additionalCharacteristic",                                                                      // MakerGen.cs:236
                        Id = "CatalogEntry.additionalCharacteristic",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. CatalogEntry.additionalClassification
                    this.AdditionalClassification = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AdditionalClassification",                                                                                  // MakerGen.cs:235
                        Path= "CatalogEntry.additionalClassification",                                                                      // MakerGen.cs:236
                        Id = "CatalogEntry.additionalClassification",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. CatalogEntry.relatedEntry
                    this.RelatedEntry = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RelatedEntry",                                                                                              // MakerGen.cs:235
                        Path= "CatalogEntry.relatedEntry",                                                                                  // MakerGen.cs:236
                        Id = "CatalogEntry.relatedEntry",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_RelatedEntry                                                                                           // MakerGen.cs:259
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
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Orderable.Write(sDef);                                                                                                      // MakerGen.cs:220
                ReferencedItem.Write(sDef);                                                                                                 // MakerGen.cs:220
                AdditionalIdentifier.Write(sDef);                                                                                           // MakerGen.cs:220
                Classification.Write(sDef);                                                                                                 // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                ValidityPeriod.Write(sDef);                                                                                                 // MakerGen.cs:220
                ValidTo.Write(sDef);                                                                                                        // MakerGen.cs:220
                LastUpdated.Write(sDef);                                                                                                    // MakerGen.cs:220
                AdditionalCharacteristic.Write(sDef);                                                                                       // MakerGen.cs:220
                AdditionalClassification.Write(sDef);                                                                                       // MakerGen.cs:220
                RelatedEntry.Write(sDef);                                                                                                   // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public CatalogEntry_Elements Elements { get; }                                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public CatalogEntry()                                                                                                               // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new CatalogEntry_Elements();                                                                                    // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
