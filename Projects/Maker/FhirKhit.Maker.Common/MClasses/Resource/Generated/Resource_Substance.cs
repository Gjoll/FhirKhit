using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'Substance'
    /// </summary>
    // 0. Substance
    public class Resource_Substance : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_Substance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 6. Substance.instance
            public class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Instance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 7. Substance.instance.identifier
                    public ElementDefinitionInfo Element_Identifier;                                                                        // MakerGen.cs:211
                    // 8. Substance.instance.expiry
                    public ElementDefinitionInfo Element_Expiry;                                                                            // MakerGen.cs:211
                    // 9. Substance.instance.quantity
                    public ElementDefinitionInfo Element_Quantity;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Instance_Elements()                                                                                         // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. Substance.instance.identifier
                            this.Element_Identifier = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Identifier",                                                                                // MakerGen.cs:230
                                Path= "Substance.instance.identifier",                                                                      // MakerGen.cs:231
                                Id = "Substance.instance.identifier",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Identifier                                                       // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 8. Substance.instance.expiry
                            this.Element_Expiry = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Expiry",                                                                                    // MakerGen.cs:230
                                Path= "Substance.instance.expiry",                                                                          // MakerGen.cs:231
                                Id = "Substance.instance.expiry",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. Substance.instance.quantity
                            this.Element_Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Quantity",                                                                                  // MakerGen.cs:230
                                Path= "Substance.instance.quantity",                                                                        // MakerGen.cs:231
                                Id = "Substance.instance.quantity",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Identifier.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_Expiry.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Quantity.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Instance_Elements Elements                                                                                      // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Instance_Elements();                                                                   // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Instance_Elements elements;                                                                                            // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Instance()                                                                                                      // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Substance.instance",                                                                                        // MakerGen.cs:420
                        ElementId = "Substance.instance"                                                                                    // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 10. Substance.ingredient
            public class Type_Ingredient : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Ingredient_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 11. Substance.ingredient.quantity
                    public ElementDefinitionInfo Element_Quantity;                                                                          // MakerGen.cs:211
                    // 12. Substance.ingredient.substance[x]
                    public ElementDefinitionInfo Element_Substance;                                                                         // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Ingredient_Elements()                                                                                       // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. Substance.ingredient.quantity
                            this.Element_Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Quantity",                                                                                  // MakerGen.cs:230
                                Path= "Substance.ingredient.quantity",                                                                      // MakerGen.cs:231
                                Id = "Substance.ingredient.quantity",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. Substance.ingredient.substance[x]
                            this.Element_Substance = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Substance",                                                                                 // MakerGen.cs:230
                                Path= "Substance.ingredient.substance[x]",                                                                  // MakerGen.cs:231
                                Id = "Substance.ingredient.substance[x]",                                                                   // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    },                                                                                                      // MakerGen.cs:314
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Substance"                                             // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Quantity.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Substance.Write(sDef);                                                                                      // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Ingredient_Elements Elements                                                                                    // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Ingredient_Elements();                                                                 // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Ingredient_Elements elements;                                                                                          // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Ingredient()                                                                                                    // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Substance.ingredient",                                                                                      // MakerGen.cs:420
                        ElementId = "Substance.ingredient"                                                                                  // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. Substance.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. Substance.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 3. Substance.category
            public ElementDefinitionInfo Element_Category;                                                                                  // MakerGen.cs:211
            // 4. Substance.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:211
            // 5. Substance.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:211
            // 6. Substance.instance
            public ElementDefinitionInfo Element_Instance;                                                                                  // MakerGen.cs:211
            // 10. Substance.ingredient
            public ElementDefinitionInfo Element_Ingredient;                                                                                // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_Substance_Elements()                                                                                            // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Substance.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "Substance.identifier",                                                                                       // MakerGen.cs:231
                        Id = "Substance.identifier",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Substance.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "Substance.status",                                                                                           // MakerGen.cs:231
                        Id = "Substance.status",                                                                                            // MakerGen.cs:232
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
                    // 3. Substance.category
                    this.Element_Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Category",                                                                                          // MakerGen.cs:230
                        Path= "Substance.category",                                                                                         // MakerGen.cs:231
                        Id = "Substance.category",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Substance.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Code",                                                                                              // MakerGen.cs:230
                        Path= "Substance.code",                                                                                             // MakerGen.cs:231
                        Id = "Substance.code",                                                                                              // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Substance.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Description",                                                                                       // MakerGen.cs:230
                        Path= "Substance.description",                                                                                      // MakerGen.cs:231
                        Id = "Substance.description",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Substance.instance
                    this.Element_Instance = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Instance",                                                                                          // MakerGen.cs:230
                        Path= "Substance.instance",                                                                                         // MakerGen.cs:231
                        Id = "Substance.instance",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Instance                                                                                               // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. Substance.ingredient
                    this.Element_Ingredient = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Ingredient",                                                                                        // MakerGen.cs:230
                        Path= "Substance.ingredient",                                                                                       // MakerGen.cs:231
                        Id = "Substance.ingredient",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Ingredient                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Category.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Instance.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Ingredient.Write(sDef);                                                                                             // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_Substance_Elements Elements                                                                                         // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_Substance_Elements();                                                                      // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_Substance_Elements elements;                                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_Substance()                                                                                                         // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "Substance";                                                                                                        // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Substance";                                                                 // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Substance",                                                                                                         // MakerGen.cs:420
                ElementId = "Substance"                                                                                                     // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
