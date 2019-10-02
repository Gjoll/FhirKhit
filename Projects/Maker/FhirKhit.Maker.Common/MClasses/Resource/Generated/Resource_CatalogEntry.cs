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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'CatalogEntry'
    /// </summary>
    // 0. CatalogEntry
    public class Resource_CatalogEntry : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                             // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 13. CatalogEntry.relatedEntry
        public class Type_RelatedEntry : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 14. CatalogEntry.relatedEntry.relationtype
            public ElementDefinitionInfo Element_Relationtype;                                                                              // MakerGen.cs:219
            // 15. CatalogEntry.relatedEntry.item
            public ElementDefinitionInfo Element_Item;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "CatalogEntry.relatedEntry",                                                                                     // MakerGen.cs:395
                    ElementId = "CatalogEntry.relatedEntry"                                                                                 // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Relationtype.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_Item.Write(sDef);                                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_RelatedEntry()                                                                                                      // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 14. CatalogEntry.relatedEntry.relationtype
                    this.Element_Relationtype = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Relationtype",                                                                                      // MakerGen.cs:238
                        Path= "CatalogEntry.relatedEntry.relationtype",                                                                     // MakerGen.cs:239
                        Id = "CatalogEntry.relatedEntry.relationtype",                                                                      // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
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
                    // 15. CatalogEntry.relatedEntry.item
                    this.Element_Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Item",                                                                                              // MakerGen.cs:238
                        Path= "CatalogEntry.relatedEntry.item",                                                                             // MakerGen.cs:239
                        Id = "CatalogEntry.relatedEntry.item",                                                                              // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CatalogEntry"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. CatalogEntry.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. CatalogEntry.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 3. CatalogEntry.orderable
        public ElementDefinitionInfo Element_Orderable;                                                                                     // MakerGen.cs:219
        // 4. CatalogEntry.referencedItem
        public ElementDefinitionInfo Element_ReferencedItem;                                                                                // MakerGen.cs:219
        // 5. CatalogEntry.additionalIdentifier
        public ElementDefinitionInfo Element_AdditionalIdentifier;                                                                          // MakerGen.cs:219
        // 6. CatalogEntry.classification
        public ElementDefinitionInfo Element_Classification;                                                                                // MakerGen.cs:219
        // 7. CatalogEntry.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 8. CatalogEntry.validityPeriod
        public ElementDefinitionInfo Element_ValidityPeriod;                                                                                // MakerGen.cs:219
        // 9. CatalogEntry.validTo
        public ElementDefinitionInfo Element_ValidTo;                                                                                       // MakerGen.cs:219
        // 10. CatalogEntry.lastUpdated
        public ElementDefinitionInfo Element_LastUpdated;                                                                                   // MakerGen.cs:219
        // 11. CatalogEntry.additionalCharacteristic
        public ElementDefinitionInfo Element_AdditionalCharacteristic;                                                                      // MakerGen.cs:219
        // 12. CatalogEntry.additionalClassification
        public ElementDefinitionInfo Element_AdditionalClassification;                                                                      // MakerGen.cs:219
        // 13. CatalogEntry.relatedEntry
        public ElementDefinitionInfo Element_RelatedEntry;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "CatalogEntry",                                                                                                      // MakerGen.cs:395
                ElementId = "CatalogEntry"                                                                                                  // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Orderable.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_ReferencedItem.Write(sDef);                                                                                             // MakerGen.cs:223
            Element_AdditionalIdentifier.Write(sDef);                                                                                       // MakerGen.cs:223
            Element_Classification.Write(sDef);                                                                                             // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_ValidityPeriod.Write(sDef);                                                                                             // MakerGen.cs:223
            Element_ValidTo.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_LastUpdated.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_AdditionalCharacteristic.Write(sDef);                                                                                   // MakerGen.cs:223
            Element_AdditionalClassification.Write(sDef);                                                                                   // MakerGen.cs:223
            Element_RelatedEntry.Write(sDef);                                                                                               // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_CatalogEntry()                                                                                                      // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. CatalogEntry.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "CatalogEntry.identifier",                                                                                        // MakerGen.cs:239
                    Id = "CatalogEntry.identifier",                                                                                         // MakerGen.cs:240
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
                // 2. CatalogEntry.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "CatalogEntry.type",                                                                                              // MakerGen.cs:239
                    Id = "CatalogEntry.type",                                                                                               // MakerGen.cs:240
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
                // 3. CatalogEntry.orderable
                this.Element_Orderable = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Orderable",                                                                                             // MakerGen.cs:238
                    Path= "CatalogEntry.orderable",                                                                                         // MakerGen.cs:239
                    Id = "CatalogEntry.orderable",                                                                                          // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. CatalogEntry.referencedItem
                this.Element_ReferencedItem = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReferencedItem",                                                                                        // MakerGen.cs:238
                    Path= "CatalogEntry.referencedItem",                                                                                    // MakerGen.cs:239
                    Id = "CatalogEntry.referencedItem",                                                                                     // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Medication",                                                       // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                                // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                               // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                                   // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition",                                               // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/ObservationDefinition",                                            // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Binary"                                                            // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. CatalogEntry.additionalIdentifier
                this.Element_AdditionalIdentifier = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AdditionalIdentifier",                                                                                  // MakerGen.cs:238
                    Path= "CatalogEntry.additionalIdentifier",                                                                              // MakerGen.cs:239
                    Id = "CatalogEntry.additionalIdentifier",                                                                               // MakerGen.cs:240
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
                // 6. CatalogEntry.classification
                this.Element_Classification = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Classification",                                                                                        // MakerGen.cs:238
                    Path= "CatalogEntry.classification",                                                                                    // MakerGen.cs:239
                    Id = "CatalogEntry.classification",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. CatalogEntry.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "CatalogEntry.status",                                                                                            // MakerGen.cs:239
                    Id = "CatalogEntry.status",                                                                                             // MakerGen.cs:240
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
                // 8. CatalogEntry.validityPeriod
                this.Element_ValidityPeriod = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ValidityPeriod",                                                                                        // MakerGen.cs:238
                    Path= "CatalogEntry.validityPeriod",                                                                                    // MakerGen.cs:239
                    Id = "CatalogEntry.validityPeriod",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. CatalogEntry.validTo
                this.Element_ValidTo = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ValidTo",                                                                                               // MakerGen.cs:238
                    Path= "CatalogEntry.validTo",                                                                                           // MakerGen.cs:239
                    Id = "CatalogEntry.validTo",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. CatalogEntry.lastUpdated
                this.Element_LastUpdated = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_LastUpdated",                                                                                           // MakerGen.cs:238
                    Path= "CatalogEntry.lastUpdated",                                                                                       // MakerGen.cs:239
                    Id = "CatalogEntry.lastUpdated",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. CatalogEntry.additionalCharacteristic
                this.Element_AdditionalCharacteristic = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AdditionalCharacteristic",                                                                              // MakerGen.cs:238
                    Path= "CatalogEntry.additionalCharacteristic",                                                                          // MakerGen.cs:239
                    Id = "CatalogEntry.additionalCharacteristic",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. CatalogEntry.additionalClassification
                this.Element_AdditionalClassification = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AdditionalClassification",                                                                              // MakerGen.cs:238
                    Path= "CatalogEntry.additionalClassification",                                                                          // MakerGen.cs:239
                    Id = "CatalogEntry.additionalClassification",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 13. CatalogEntry.relatedEntry
                this.Element_RelatedEntry = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_RelatedEntry",                                                                                          // MakerGen.cs:238
                    Path= "CatalogEntry.relatedEntry",                                                                                      // MakerGen.cs:239
                    Id = "CatalogEntry.relatedEntry",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_RelatedEntry                                                                                               // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "CatalogEntry";                                                                                                     // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CatalogEntry";                                                              // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
