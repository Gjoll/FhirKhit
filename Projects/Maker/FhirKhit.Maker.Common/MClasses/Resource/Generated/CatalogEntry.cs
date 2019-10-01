using System;                                                                                                                               // MakerGen.cs:399
using System.Diagnostics;                                                                                                                   // MakerGen.cs:400
using System.IO;                                                                                                                            // MakerGen.cs:401
using System.Linq;                                                                                                                          // MakerGen.cs:402
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:403
                                                                                                                                            // MakerGen.cs:404
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:405
{                                                                                                                                           // MakerGen.cs:406
    #region Json                                                                                                                            // MakerGen.cs:407
    #if NEVER                                                                                                                               // MakerGen.cs:408
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
    #endregion                                                                                                                              // MakerGen.cs:411
    /// <summary>
    /// Fhir resource 'CatalogEntry'
    /// </summary>
    // 0. CatalogEntry
    public class CatalogEntry : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:360
    {                                                                                                                                       // MakerGen.cs:361
        // 13. CatalogEntry.relatedEntry
        public class Type_RelatedEntry : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 14. CatalogEntry.relatedEntry.relationtype
            public MakerElementInstance Element_Relationtype;                                                                               // MakerGen.cs:232
            // 15. CatalogEntry.relatedEntry.item
            public MakerElementInstance Element_Item;                                                                                       // MakerGen.cs:232
            public Type_RelatedEntry()                                                                                                      // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 14. CatalogEntry.relatedEntry.relationtype
                    this.Element_Relationtype = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Relationtype",                                                                                      // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 15. CatalogEntry.relatedEntry.item
                    this.Element_Item = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Item",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 1. CatalogEntry.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. CatalogEntry.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 3. CatalogEntry.orderable
        public MakerElementInstance Element_Orderable;                                                                                      // MakerGen.cs:232
        // 4. CatalogEntry.referencedItem
        public MakerElementInstance Element_ReferencedItem;                                                                                 // MakerGen.cs:232
        // 5. CatalogEntry.additionalIdentifier
        public MakerElementInstance Element_AdditionalIdentifier;                                                                           // MakerGen.cs:232
        // 6. CatalogEntry.classification
        public MakerElementInstance Element_Classification;                                                                                 // MakerGen.cs:232
        // 7. CatalogEntry.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 8. CatalogEntry.validityPeriod
        public MakerElementInstance Element_ValidityPeriod;                                                                                 // MakerGen.cs:232
        // 9. CatalogEntry.validTo
        public MakerElementInstance Element_ValidTo;                                                                                        // MakerGen.cs:232
        // 10. CatalogEntry.lastUpdated
        public MakerElementInstance Element_LastUpdated;                                                                                    // MakerGen.cs:232
        // 11. CatalogEntry.additionalCharacteristic
        public MakerElementInstance Element_AdditionalCharacteristic;                                                                       // MakerGen.cs:232
        // 12. CatalogEntry.additionalClassification
        public MakerElementInstance Element_AdditionalClassification;                                                                       // MakerGen.cs:232
        public CatalogEntry()                                                                                                               // MakerGen.cs:369
        {                                                                                                                                   // MakerGen.cs:370
            {                                                                                                                               // MakerGen.cs:243
                // 1. CatalogEntry.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 2. CatalogEntry.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 3. CatalogEntry.orderable
                this.Element_Orderable = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Orderable",                                                                                             // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 4. CatalogEntry.referencedItem
                this.Element_ReferencedItem = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReferencedItem",                                                                                        // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 5. CatalogEntry.additionalIdentifier
                this.Element_AdditionalIdentifier = new MakerElementInstance                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AdditionalIdentifier",                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 6. CatalogEntry.classification
                this.Element_Classification = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Classification",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 7. CatalogEntry.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 8. CatalogEntry.validityPeriod
                this.Element_ValidityPeriod = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ValidityPeriod",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 9. CatalogEntry.validTo
                this.Element_ValidTo = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ValidTo",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 10. CatalogEntry.lastUpdated
                this.Element_LastUpdated = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LastUpdated",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 11. CatalogEntry.additionalCharacteristic
                this.Element_AdditionalCharacteristic = new MakerElementInstance                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AdditionalCharacteristic",                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 12. CatalogEntry.additionalClassification
                this.Element_AdditionalClassification = new MakerElementInstance                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AdditionalClassification",                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
        }                                                                                                                                   // MakerGen.cs:381
    }                                                                                                                                       // MakerGen.cs:365
}                                                                                                                                           // MakerGen.cs:416
