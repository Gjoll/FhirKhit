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
      "id": "Substance",
      "url": "http://hl7.org/fhir/StructureDefinition/Substance",
      "version": "4.0.0",
      "name": "Substance",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A homogeneous material with a definite composition.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Substance",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Substance",
            "path": "Substance",
            "short": "A homogeneous material with a definite composition",
            "definition": "A homogeneous material with a definite composition.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Substance.identifier",
            "path": "Substance.identifier",
            "short": "Unique identifier",
            "definition": "Unique identifier for the substance.",
            "comment": "This identifier is associated with the kind of substance in contrast to the  Substance.instance.identifier which is associated with the package/container.",
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
            "id": "Substance.status",
            "path": "Substance.status",
            "short": "active | inactive | entered-in-error",
            "definition": "A code to indicate if the substance is actively used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FHIRSubstanceStatus"
                }
              ],
              "strength": "required",
              "description": "A code to indicate if the substance is actively used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-status|4.0.0"
            }
          },
          {
            "id": "Substance.category",
            "path": "Substance.category",
            "short": "What class/type of substance this is",
            "definition": "A code that classifies the general type of substance.  This is used  for searching, sorting and display purposes.",
            "comment": "The level of granularity is defined by the category concepts in the value set.   More fine-grained filtering can be performed using the metadata and/or terminology hierarchy in Substance.code.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SubstanceCategory"
                }
              ],
              "strength": "extensible",
              "description": "Category or classification of substance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-category"
            }
          },
          {
            "id": "Substance.code",
            "path": "Substance.code",
            "short": "What substance this is",
            "definition": "A code (or set of codes) that identify this substance.",
            "comment": "This could be a reference to an externally defined code.  It could also be a locally assigned code (e.g. a formulary),  optionally with translations to the standard drug codes.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SubstanceCode"
                }
              ],
              "strength": "example",
              "description": "Substance codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-code"
            }
          },
          {
            "id": "Substance.description",
            "path": "Substance.description",
            "short": "Textual description of the substance, comments",
            "definition": "A description of the substance - its appearance, handling requirements, and other usage notes.",
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
            "id": "Substance.instance",
            "path": "Substance.instance",
            "short": "If this describes a specific package/container of the substance",
            "definition": "Substance may be used to describe a kind of substance, or a specific package/container of the substance: an instance.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "meaningWhenMissing": "If this element is not present, then the substance resource describes a kind of substance",
            "isSummary": true
          },
          {
            "id": "Substance.instance.identifier",
            "path": "Substance.instance.identifier",
            "short": "Identifier of the package/container",
            "definition": "Identifier associated with the package/container (usually a label affixed directly).",
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
            "id": "Substance.instance.expiry",
            "path": "Substance.instance.expiry",
            "short": "When no longer valid to use",
            "definition": "When the substance is no longer valid to use. For some substances, a single arbitrary date is used for expiry.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Substance.instance.quantity",
            "path": "Substance.instance.quantity",
            "short": "Amount of substance in the package",
            "definition": "The amount of the substance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Substance.ingredient",
            "path": "Substance.ingredient",
            "short": "Composition information about the substance",
            "definition": "A substance can be composed of other substances.",
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
            "id": "Substance.ingredient.quantity",
            "path": "Substance.ingredient.quantity",
            "short": "Optional amount (concentration)",
            "definition": "The amount of the ingredient in the substance - a concentration ratio.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Substance.ingredient.substance[x]",
            "path": "Substance.ingredient.substance[x]",
            "short": "A component of the substance",
            "definition": "Another substance that is a component of this substance.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SubstanceIngredient"
                }
              ],
              "strength": "example",
              "description": "Substance Ingredient codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-code"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Substance'
    /// </summary>
    // 0. Substance
    public class Substance : FhirKhit.Maker.Common.Resource.ResourceBase                                                                    // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Substance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                       // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 6. Substance.instance
            public class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Instance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 7. Substance.instance.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:236
                    // 8. Substance.instance.expiry
                    public ElementDefinitionInfo Expiry;                                                                                    // MakerGen.cs:236
                    // 9. Substance.instance.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:236
                    public Type_Instance_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 7. Substance.instance.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Identifier",                                                                                        // MakerGen.cs:255
                                Path= "Substance.instance.identifier",                                                                      // MakerGen.cs:256
                                Id = "Substance.instance.identifier",                                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 8. Substance.instance.expiry
                            this.Expiry = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Expiry",                                                                                            // MakerGen.cs:255
                                Path= "Substance.instance.expiry",                                                                          // MakerGen.cs:256
                                Id = "Substance.instance.expiry",                                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. Substance.instance.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Quantity",                                                                                          // MakerGen.cs:255
                                Path= "Substance.instance.quantity",                                                                        // MakerGen.cs:256
                                Id = "Substance.instance.quantity",                                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:240
                        Expiry.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Instance_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Instance()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Instance_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 10. Substance.ingredient
            public class Type_Ingredient : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Ingredient_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 11. Substance.ingredient.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:236
                    // 12. Substance.ingredient.substance[x]
                    public ElementDefinitionInfo Substance;                                                                                 // MakerGen.cs:236
                    public Type_Ingredient_Elements()                                                                                       // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 11. Substance.ingredient.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Quantity",                                                                                          // MakerGen.cs:255
                                Path= "Substance.ingredient.quantity",                                                                      // MakerGen.cs:256
                                Id = "Substance.ingredient.quantity",                                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 12. Substance.ingredient.substance[x]
                            this.Substance = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Substance",                                                                                         // MakerGen.cs:255
                                Path= "Substance.ingredient.substance[x]",                                                                  // MakerGen.cs:256
                                Id = "Substance.ingredient.substance[x]",                                                                   // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
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
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:240
                        Substance.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Ingredient_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Ingredient()                                                                                                    // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Ingredient_Elements();                                                                         // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. Substance.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. Substance.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. Substance.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:236
            // 4. Substance.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 5. Substance.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:236
            public Substance_Elements()                                                                                                     // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Substance.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "Substance.identifier",                                                                                       // MakerGen.cs:256
                        Id = "Substance.identifier",                                                                                        // MakerGen.cs:257
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
                    // 2. Substance.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "Substance.status",                                                                                           // MakerGen.cs:256
                        Id = "Substance.status",                                                                                            // MakerGen.cs:257
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
                    // 3. Substance.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Category",                                                                                                  // MakerGen.cs:255
                        Path= "Substance.category",                                                                                         // MakerGen.cs:256
                        Id = "Substance.category",                                                                                          // MakerGen.cs:257
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
                    // 4. Substance.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "Substance.code",                                                                                             // MakerGen.cs:256
                        Id = "Substance.code",                                                                                              // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 5. Substance.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Description",                                                                                               // MakerGen.cs:255
                        Path= "Substance.description",                                                                                      // MakerGen.cs:256
                        Id = "Substance.description",                                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Category.Write(sDef);                                                                                                       // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Description.Write(sDef);                                                                                                    // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Substance_Elements Elements { get; }                                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Substance()                                                                                                                  // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Substance_Elements();                                                                                       // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
