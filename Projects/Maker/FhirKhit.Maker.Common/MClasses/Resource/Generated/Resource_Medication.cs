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
      "id": "Medication",
      "url": "http://hl7.org/fhir/StructureDefinition/Medication",
      "version": "4.0.0",
      "name": "Medication",
      "status": "draft",
      "publisher": "Health Level Seven International (Pharmacy)",
      "description": "This resource is primarily used for the identification and definition of a medication for the purposes of prescribing, dispensing, and administering a medication as well as for making statements about medication use.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Medication",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Medication",
            "path": "Medication",
            "short": "Definition of a Medication",
            "definition": "This resource is primarily used for the identification and definition of a medication for the purposes of prescribing, dispensing, and administering a medication as well as for making statements about medication use.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Medication.identifier",
            "path": "Medication.identifier",
            "short": "Business identifier for this medication",
            "definition": "Business identifier for this medication.",
            "comment": "The serial number could be included as an identifier.",
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
            "id": "Medication.code",
            "path": "Medication.code",
            "short": "Codes that identify this medication",
            "definition": "A code (or set of codes) that specify this medication, or a textual description if no code is available. Usage note: This could be a standard medication code such as a code from RxNorm, SNOMED CT, IDMP etc. It could also be a national or local formulary code, optionally with translations to other code systems.",
            "comment": "Depending on the context of use, the code that was actually selected by the user (prescriber, dispenser, etc.) will have the coding.userSelected set to true.  As described in the coding datatype: \"A coding may be marked as a \"userSelected\" if a user selected the particular coded value in a user interface (e.g. the user selects an item in a pick-list). If a user selected coding exists, it is the preferred choice for performing translations etc. Other codes can only be literal translations to alternative code systems, or codes at a lower level of granularity (e.g. a generic code for a vendor-specific primary one).",
            "min": 0,
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
                  "valueString": "MedicationFormalRepresentation"
                }
              ],
              "strength": "example",
              "description": "A coded concept that defines the type of a medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-codes"
            }
          },
          {
            "id": "Medication.status",
            "path": "Medication.status",
            "short": "active | inactive | entered-in-error",
            "definition": "A code to indicate if the medication is in active use.",
            "comment": "This status is intended to identify if the medication in a local system is in active use within a drug database or inventory.  For example, a pharmacy system may create a new drug file record for a compounded product \"ABC Hospital Special Cream\" with an active status.  At some point in the future, it may be determined that the drug record was created with an error and the status is changed to \"entered in error\".   This status is not intended to specify if a medication is part of a particular formulary.  It is possible that the drug record may be referenced by multiple formularies or catalogues and each of those entries would have a separate status.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element changes the interpretation of all descriptive attributes.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationStatus"
                }
              ],
              "strength": "required",
              "description": "A coded concept defining if the medication is in active use.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-status|4.0.0"
            }
          },
          {
            "id": "Medication.manufacturer",
            "path": "Medication.manufacturer",
            "short": "Manufacturer of the item",
            "definition": "Describes the details of the manufacturer of the medication product.  This is not intended to represent the distributor of a medication product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Medication.form",
            "path": "Medication.form",
            "short": "powder | tablets | capsule +",
            "definition": "Describes the form of the item.  Powder; tablets; capsule.",
            "comment": "When Medication is referenced from MedicationRequest, this is the ordered form.  When Medication is referenced within MedicationDispense, this is the dispensed form.  When Medication is referenced within MedicationAdministration, this is administered form.",
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
                  "valueString": "MedicationForm"
                }
              ],
              "strength": "example",
              "description": "A coded concept defining the form of a medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-form-codes"
            }
          },
          {
            "id": "Medication.amount",
            "path": "Medication.amount",
            "short": "Amount of drug in package",
            "definition": "Specific amount of the drug in the packaged product.  For example, when specifying a product that has the same strength (For example, Insulin glargine 100 unit per mL solution for injection), this attribute provides additional clarification of the package amount (For example, 3 mL, 10mL, etc.).",
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
            "id": "Medication.ingredient",
            "path": "Medication.ingredient",
            "short": "Active or inactive ingredient",
            "definition": "Identifies a particular constituent of interest in the product.",
            "comment": "The ingredients need not be a complete list.  If an ingredient is not specified, this does not indicate whether an ingredient is present or absent.  If an ingredient is specified it does not mean that all ingredients are specified.  It is possible to specify both inactive and active ingredients.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Medication.ingredient.item[x]",
            "path": "Medication.ingredient.item[x]",
            "short": "The actual ingredient or content",
            "definition": "The actual ingredient - either a substance (simple ingredient) or another medication of a medication.",
            "requirements": "The ingredient may reference a substance (for example, amoxicillin) or another medication (for example in the case of a compounded product, Glaxal Base).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Medication"
                ]
              }
            ]
          },
          {
            "id": "Medication.ingredient.isActive",
            "path": "Medication.ingredient.isActive",
            "short": "Active ingredient indicator",
            "definition": "Indication of whether this ingredient affects the therapeutic action of the drug.",
            "requirements": "True indicates that the ingredient affects the therapeutic action of the drug (i.e. active). \rFalse indicates that the ingredient does not affect the therapeutic action of the drug (i.e. inactive).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "Medication.ingredient.strength",
            "path": "Medication.ingredient.strength",
            "short": "Quantity of ingredient present",
            "definition": "Specifies how many (or how much) of the items there are in this Medication.  For example, 250 mg per tablet.  This is expressed as a ratio where the numerator is 250mg and the denominator is 1 tablet.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ]
          },
          {
            "id": "Medication.batch",
            "path": "Medication.batch",
            "short": "Details about packaged medications",
            "definition": "Information that only applies to packages (not products).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Medication.batch.lotNumber",
            "path": "Medication.batch.lotNumber",
            "short": "Identifier assigned to batch",
            "definition": "The assigned lot number of a batch of the specified product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Medication.batch.expirationDate",
            "path": "Medication.batch.expirationDate",
            "short": "When batch will expire",
            "definition": "When this specific batch of product will expire.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'Medication'
    /// </summary>
    // 0. Medication
    public class Resource_Medication : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_Medication_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 7. Medication.ingredient
            public class Type_Ingredient : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Ingredient_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 8. Medication.ingredient.item[x]
                    public ElementDefinitionInfo Element_Item;                                                                              // MakerGen.cs:211
                    // 9. Medication.ingredient.isActive
                    public ElementDefinitionInfo Element_IsActive;                                                                          // MakerGen.cs:211
                    // 10. Medication.ingredient.strength
                    public ElementDefinitionInfo Element_Strength;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Ingredient_Elements()                                                                                       // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 8. Medication.ingredient.item[x]
                            this.Element_Item = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Item",                                                                                      // MakerGen.cs:230
                                Path= "Medication.ingredient.item[x]",                                                                      // MakerGen.cs:231
                                Id = "Medication.ingredient.item[x]",                                                                       // MakerGen.cs:232
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
                                            "http://hl7.org/fhir/StructureDefinition/Substance",                                            // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Medication"                                            // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. Medication.ingredient.isActive
                            this.Element_IsActive = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_IsActive",                                                                                  // MakerGen.cs:230
                                Path= "Medication.ingredient.isActive",                                                                     // MakerGen.cs:231
                                Id = "Medication.ingredient.isActive",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. Medication.ingredient.strength
                            this.Element_Strength = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Strength",                                                                                  // MakerGen.cs:230
                                Path= "Medication.ingredient.strength",                                                                     // MakerGen.cs:231
                                Id = "Medication.ingredient.strength",                                                                      // MakerGen.cs:232
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Item.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_IsActive.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Strength.Write(sDef);                                                                                       // MakerGen.cs:215
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
                        Path = "Medication.ingredient",                                                                                     // MakerGen.cs:420
                        ElementId = "Medication.ingredient"                                                                                 // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 11. Medication.batch
            public class Type_Batch : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Batch_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 12. Medication.batch.lotNumber
                    public ElementDefinitionInfo Element_LotNumber;                                                                         // MakerGen.cs:211
                    // 13. Medication.batch.expirationDate
                    public ElementDefinitionInfo Element_ExpirationDate;                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Batch_Elements()                                                                                            // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. Medication.batch.lotNumber
                            this.Element_LotNumber = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_LotNumber",                                                                                 // MakerGen.cs:230
                                Path= "Medication.batch.lotNumber",                                                                         // MakerGen.cs:231
                                Id = "Medication.batch.lotNumber",                                                                          // MakerGen.cs:232
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
                            // 13. Medication.batch.expirationDate
                            this.Element_ExpirationDate = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ExpirationDate",                                                                            // MakerGen.cs:230
                                Path= "Medication.batch.expirationDate",                                                                    // MakerGen.cs:231
                                Id = "Medication.batch.expirationDate",                                                                     // MakerGen.cs:232
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_LotNumber.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_ExpirationDate.Write(sDef);                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Batch_Elements Elements                                                                                         // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Batch_Elements();                                                                      // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Batch_Elements elements;                                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Batch()                                                                                                         // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Medication.batch",                                                                                          // MakerGen.cs:420
                        ElementId = "Medication.batch"                                                                                      // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. Medication.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. Medication.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:211
            // 3. Medication.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 4. Medication.manufacturer
            public ElementDefinitionInfo Element_Manufacturer;                                                                              // MakerGen.cs:211
            // 5. Medication.form
            public ElementDefinitionInfo Element_Form;                                                                                      // MakerGen.cs:211
            // 6. Medication.amount
            public ElementDefinitionInfo Element_Amount;                                                                                    // MakerGen.cs:211
            // 7. Medication.ingredient
            public ElementDefinitionInfo Element_Ingredient;                                                                                // MakerGen.cs:211
            // 11. Medication.batch
            public ElementDefinitionInfo Element_Batch;                                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_Medication_Elements()                                                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Medication.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "Medication.identifier",                                                                                      // MakerGen.cs:231
                        Id = "Medication.identifier",                                                                                       // MakerGen.cs:232
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
                    // 2. Medication.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Code",                                                                                              // MakerGen.cs:230
                        Path= "Medication.code",                                                                                            // MakerGen.cs:231
                        Id = "Medication.code",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 3. Medication.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "Medication.status",                                                                                          // MakerGen.cs:231
                        Id = "Medication.status",                                                                                           // MakerGen.cs:232
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
                    // 4. Medication.manufacturer
                    this.Element_Manufacturer = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Manufacturer",                                                                                      // MakerGen.cs:230
                        Path= "Medication.manufacturer",                                                                                    // MakerGen.cs:231
                        Id = "Medication.manufacturer",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Medication.form
                    this.Element_Form = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Form",                                                                                              // MakerGen.cs:230
                        Path= "Medication.form",                                                                                            // MakerGen.cs:231
                        Id = "Medication.form",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 6. Medication.amount
                    this.Element_Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:230
                        Path= "Medication.amount",                                                                                          // MakerGen.cs:231
                        Id = "Medication.amount",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                    // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. Medication.ingredient
                    this.Element_Ingredient = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Ingredient",                                                                                        // MakerGen.cs:230
                        Path= "Medication.ingredient",                                                                                      // MakerGen.cs:231
                        Id = "Medication.ingredient",                                                                                       // MakerGen.cs:232
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
                {                                                                                                                           // MakerGen.cs:226
                    // 11. Medication.batch
                    this.Element_Batch = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Batch",                                                                                             // MakerGen.cs:230
                        Path= "Medication.batch",                                                                                           // MakerGen.cs:231
                        Id = "Medication.batch",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Batch                                                                                                  // MakerGen.cs:254
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
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Manufacturer.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Form.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Amount.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Ingredient.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Batch.Write(sDef);                                                                                                  // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_Medication_Elements Elements                                                                                        // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_Medication_Elements();                                                                     // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_Medication_Elements elements;                                                                                              // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_Medication()                                                                                                        // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "Medication";                                                                                                       // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Medication";                                                                // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Medication",                                                                                                        // MakerGen.cs:420
                ElementId = "Medication"                                                                                                    // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
