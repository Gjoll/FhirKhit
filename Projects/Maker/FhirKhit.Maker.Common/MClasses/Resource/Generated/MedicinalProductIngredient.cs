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
      "id": "MedicinalProductIngredient",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient",
      "version": "4.0.0",
      "name": "MedicinalProductIngredient",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "An ingredient of a manufactured item or pharmaceutical product.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductIngredient",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductIngredient",
            "path": "MedicinalProductIngredient",
            "short": "An ingredient of a manufactured item or pharmaceutical product",
            "definition": "An ingredient of a manufactured item or pharmaceutical product.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductIngredient.identifier",
            "path": "MedicinalProductIngredient.identifier",
            "short": "Identifier for the ingredient",
            "definition": "The identifier(s) of this Ingredient that are assigned by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate.",
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
            "id": "MedicinalProductIngredient.role",
            "path": "MedicinalProductIngredient.role",
            "short": "Ingredient role e.g. Active ingredient, excipient",
            "definition": "Ingredient role e.g. Active ingredient, excipient.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.allergenicIndicator",
            "path": "MedicinalProductIngredient.allergenicIndicator",
            "short": "If the ingredient is a known or suspected allergen",
            "definition": "If the ingredient is a known or suspected allergen.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.manufacturer",
            "path": "MedicinalProductIngredient.manufacturer",
            "short": "Manufacturer of this Ingredient",
            "definition": "Manufacturer of this Ingredient.",
            "min": 0,
            "max": "*",
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
            "id": "MedicinalProductIngredient.specifiedSubstance",
            "path": "MedicinalProductIngredient.specifiedSubstance",
            "short": "A specified substance that comprises this ingredient",
            "definition": "A specified substance that comprises this ingredient.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.code",
            "path": "MedicinalProductIngredient.specifiedSubstance.code",
            "short": "The specified substance",
            "definition": "The specified substance.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.group",
            "path": "MedicinalProductIngredient.specifiedSubstance.group",
            "short": "The group of specified substance, e.g. group 1 to 4",
            "definition": "The group of specified substance, e.g. group 1 to 4.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.confidentiality",
            "path": "MedicinalProductIngredient.specifiedSubstance.confidentiality",
            "short": "Confidentiality level of the specified substance as the ingredient",
            "definition": "Confidentiality level of the specified substance as the ingredient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength",
            "short": "Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product",
            "definition": "Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.presentation",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.presentation",
            "short": "The quantity of substance in the unit of presentation, or in the volume (or mass) of the single pharmaceutical product or manufactured item",
            "definition": "The quantity of substance in the unit of presentation, or in the volume (or mass) of the single pharmaceutical product or manufactured item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",
            "short": "A lower limit for the quantity of substance in the unit of presentation. For use when there is a range of strengths, this is the lower limit, with the presentation attribute becoming the upper limit",
            "definition": "A lower limit for the quantity of substance in the unit of presentation. For use when there is a range of strengths, this is the lower limit, with the presentation attribute becoming the upper limit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isModifier": true,
            "isModifierReason": "If this is present it implies that the whole strength is expressed as a range, due to uncertainty or variation",
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.concentration",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.concentration",
            "short": "The strength per unitary volume (or mass)",
            "definition": "The strength per unitary volume (or mass).",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",
            "short": "A lower limit for the strength per unitary volume (or mass), for when there is a range. The concentration attribute then becomes the upper limit",
            "definition": "A lower limit for the strength per unitary volume (or mass), for when there is a range. The concentration attribute then becomes the upper limit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isModifier": true,
            "isModifierReason": "If this is present it implies that the whole strength is expressed as a range, due to uncertainty or variation",
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",
            "short": "For when strength is measured at a particular point or distance",
            "definition": "For when strength is measured at a particular point or distance.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.country",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.country",
            "short": "The country or countries for which the strength range applies",
            "definition": "The country or countries for which the strength range applies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",
            "short": "Strength expressed in terms of a reference substance",
            "definition": "Strength expressed in terms of a reference substance.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",
            "short": "Relevant reference substance",
            "definition": "Relevant reference substance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",
            "short": "Strength expressed in terms of a reference substance",
            "definition": "Strength expressed in terms of a reference substance.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",
            "short": "Strength expressed in terms of a reference substance",
            "definition": "Strength expressed in terms of a reference substance.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",
            "short": "For when strength is measured at a particular point or distance",
            "definition": "For when strength is measured at a particular point or distance.",
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
            "id": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",
            "path": "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",
            "short": "The country or countries for which the strength range applies",
            "definition": "The country or countries for which the strength range applies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.substance",
            "path": "MedicinalProductIngredient.substance",
            "short": "The ingredient substance",
            "definition": "The ingredient substance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.substance.code",
            "path": "MedicinalProductIngredient.substance.code",
            "short": "The ingredient substance",
            "definition": "The ingredient substance.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIngredient.substance.strength",
            "path": "MedicinalProductIngredient.substance.strength",
            "short": "Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product",
            "definition": "Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product.",
            "min": 0,
            "max": "*",
            "contentReference": "#MedicinalProductIngredient.specifiedSubstance.strength",
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'MedicinalProductIngredient'
    /// </summary>
    // 0. MedicinalProductIngredient
    public class MedicinalProductIngredient : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class MedicinalProductIngredient_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 5. MedicinalProductIngredient.specifiedSubstance
            public class Type_SpecifiedSubstance : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_SpecifiedSubstance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    public class Type_Strength : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Strength_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                            public class Type_ReferenceStrength : FhirKhit.Maker.Common.Complex.ComplexBase                                 // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_ReferenceStrength_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                  // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                                    public ElementDefinitionInfo Substance;                                                                 // MakerGen.cs:216
                                    // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                                    public ElementDefinitionInfo Strength;                                                                  // MakerGen.cs:216
                                    // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                                    public ElementDefinitionInfo StrengthLowLimit;                                                          // MakerGen.cs:216
                                    // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                                    public ElementDefinitionInfo MeasurementPoint;                                                          // MakerGen.cs:216
                                    // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                                    public ElementDefinitionInfo Country;                                                                   // MakerGen.cs:216
                                    public Type_ReferenceStrength_Elements()                                                                // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                                            this.Substance = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Substance",                                                                         // MakerGen.cs:235
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance", // MakerGen.cs:236
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",  // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                                            this.Strength = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Strength",                                                                          // MakerGen.cs:235
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",  // MakerGen.cs:236
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",   // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Ratio                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                                            this.StrengthLowLimit = new ElementDefinitionInfo                                               // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "StrengthLowLimit",                                                                  // MakerGen.cs:235
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",// MakerGen.cs:236
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",// MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Ratio                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                                            this.MeasurementPoint = new ElementDefinitionInfo                                               // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "MeasurementPoint",                                                                  // MakerGen.cs:235
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",// MakerGen.cs:236
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",// MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                                            this.Country = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Country",                                                                           // MakerGen.cs:235
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",   // MakerGen.cs:236
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",    // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Substance.Write(sDef);                                                                              // MakerGen.cs:220
                                        Strength.Write(sDef);                                                                               // MakerGen.cs:220
                                        StrengthLowLimit.Write(sDef);                                                                       // MakerGen.cs:220
                                        MeasurementPoint.Write(sDef);                                                                       // MakerGen.cs:220
                                        Country.Write(sDef);                                                                                // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_ReferenceStrength_Elements Elements { get; }                                                    // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_ReferenceStrength()                                                                             // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_ReferenceStrength_Elements();                                                  // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                            public ElementDefinitionInfo Presentation;                                                                      // MakerGen.cs:216
                            // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                            public ElementDefinitionInfo PresentationLowLimit;                                                              // MakerGen.cs:216
                            // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                            public ElementDefinitionInfo Concentration;                                                                     // MakerGen.cs:216
                            // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                            public ElementDefinitionInfo ConcentrationLowLimit;                                                             // MakerGen.cs:216
                            // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                            public ElementDefinitionInfo MeasurementPoint;                                                                  // MakerGen.cs:216
                            // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                            public ElementDefinitionInfo Country;                                                                           // MakerGen.cs:216
                            // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                            public ElementDefinitionInfo ReferenceStrength;                                                                 // MakerGen.cs:216
                            public Type_Strength_Elements()                                                                                 // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                                    this.Presentation = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Presentation",                                                                              // MakerGen.cs:235
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                        // MakerGen.cs:236
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                         // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Ratio                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                                    this.PresentationLowLimit = new ElementDefinitionInfo                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "PresentationLowLimit",                                                                      // MakerGen.cs:235
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                // MakerGen.cs:236
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Ratio                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                                    this.Concentration = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Concentration",                                                                             // MakerGen.cs:235
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                       // MakerGen.cs:236
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Ratio                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                                    this.ConcentrationLowLimit = new ElementDefinitionInfo                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ConcentrationLowLimit",                                                                     // MakerGen.cs:235
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",               // MakerGen.cs:236
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Ratio                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                                    this.MeasurementPoint = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "MeasurementPoint",                                                                          // MakerGen.cs:235
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",                    // MakerGen.cs:236
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                                    this.Country = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Country",                                                                                   // MakerGen.cs:235
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.country",                             // MakerGen.cs:236
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.country",                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                                    this.ReferenceStrength = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ReferenceStrength",                                                                         // MakerGen.cs:235
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                   // MakerGen.cs:236
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_ReferenceStrength                                                                      // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Presentation.Write(sDef);                                                                                   // MakerGen.cs:220
                                PresentationLowLimit.Write(sDef);                                                                           // MakerGen.cs:220
                                Concentration.Write(sDef);                                                                                  // MakerGen.cs:220
                                ConcentrationLowLimit.Write(sDef);                                                                          // MakerGen.cs:220
                                MeasurementPoint.Write(sDef);                                                                               // MakerGen.cs:220
                                Country.Write(sDef);                                                                                        // MakerGen.cs:220
                                ReferenceStrength.Write(sDef);                                                                              // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Strength_Elements Elements { get; }                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Strength()                                                                                              // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Strength_Elements();                                                                   // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 6. MedicinalProductIngredient.specifiedSubstance.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 7. MedicinalProductIngredient.specifiedSubstance.group
                    public ElementDefinitionInfo Group;                                                                                     // MakerGen.cs:216
                    // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                    public ElementDefinitionInfo Confidentiality;                                                                           // MakerGen.cs:216
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    public ElementDefinitionInfo Strength;                                                                                  // MakerGen.cs:216
                    public Type_SpecifiedSubstance_Elements()                                                                               // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 6. MedicinalProductIngredient.specifiedSubstance.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "MedicinalProductIngredient.specifiedSubstance.code",                                                 // MakerGen.cs:236
                                Id = "MedicinalProductIngredient.specifiedSubstance.code",                                                  // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 7. MedicinalProductIngredient.specifiedSubstance.group
                            this.Group = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Group",                                                                                             // MakerGen.cs:235
                                Path= "MedicinalProductIngredient.specifiedSubstance.group",                                                // MakerGen.cs:236
                                Id = "MedicinalProductIngredient.specifiedSubstance.group",                                                 // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                            this.Confidentiality = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Confidentiality",                                                                                   // MakerGen.cs:235
                                Path= "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                      // MakerGen.cs:236
                                Id = "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 9. MedicinalProductIngredient.specifiedSubstance.strength
                            this.Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Strength",                                                                                          // MakerGen.cs:235
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength",                                             // MakerGen.cs:236
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength",                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Strength                                                                                       // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Group.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Confidentiality.Write(sDef);                                                                                        // MakerGen.cs:220
                        Strength.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_SpecifiedSubstance_Elements Elements { get; }                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_SpecifiedSubstance()                                                                                            // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_SpecifiedSubstance_Elements();                                                                 // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 22. MedicinalProductIngredient.substance
            public class Type_Substance : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Substance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 23. MedicinalProductIngredient.substance.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 24. MedicinalProductIngredient.substance.strength
                    public ElementDefinitionInfo Strength;                                                                                  // MakerGen.cs:216
                    public Type_Substance_Elements()                                                                                        // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. MedicinalProductIngredient.substance.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "MedicinalProductIngredient.substance.code",                                                          // MakerGen.cs:236
                                Id = "MedicinalProductIngredient.substance.code",                                                           // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. MedicinalProductIngredient.substance.strength
                            this.Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Strength",                                                                                          // MakerGen.cs:235
                                Path= "MedicinalProductIngredient.substance.strength",                                                      // MakerGen.cs:236
                                Id = "MedicinalProductIngredient.substance.strength",                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Strength.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Substance_Elements Elements { get; }                                                                            // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Substance()                                                                                                     // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Substance_Elements();                                                                          // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. MedicinalProductIngredient.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. MedicinalProductIngredient.role
            public ElementDefinitionInfo Role;                                                                                              // MakerGen.cs:216
            // 3. MedicinalProductIngredient.allergenicIndicator
            public ElementDefinitionInfo AllergenicIndicator;                                                                               // MakerGen.cs:216
            // 4. MedicinalProductIngredient.manufacturer
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:216
            // 5. MedicinalProductIngredient.specifiedSubstance
            public ElementDefinitionInfo SpecifiedSubstance;                                                                                // MakerGen.cs:216
            // 22. MedicinalProductIngredient.substance
            public ElementDefinitionInfo Substance;                                                                                         // MakerGen.cs:216
            public MedicinalProductIngredient_Elements()                                                                                    // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicinalProductIngredient.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "MedicinalProductIngredient.identifier",                                                                      // MakerGen.cs:236
                        Id = "MedicinalProductIngredient.identifier",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MedicinalProductIngredient.role
                    this.Role = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Role",                                                                                                      // MakerGen.cs:235
                        Path= "MedicinalProductIngredient.role",                                                                            // MakerGen.cs:236
                        Id = "MedicinalProductIngredient.role",                                                                             // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 3. MedicinalProductIngredient.allergenicIndicator
                    this.AllergenicIndicator = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AllergenicIndicator",                                                                                       // MakerGen.cs:235
                        Path= "MedicinalProductIngredient.allergenicIndicator",                                                             // MakerGen.cs:236
                        Id = "MedicinalProductIngredient.allergenicIndicator",                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 4. MedicinalProductIngredient.manufacturer
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:235
                        Path= "MedicinalProductIngredient.manufacturer",                                                                    // MakerGen.cs:236
                        Id = "MedicinalProductIngredient.manufacturer",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. MedicinalProductIngredient.specifiedSubstance
                    this.SpecifiedSubstance = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SpecifiedSubstance",                                                                                        // MakerGen.cs:235
                        Path= "MedicinalProductIngredient.specifiedSubstance",                                                              // MakerGen.cs:236
                        Id = "MedicinalProductIngredient.specifiedSubstance",                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_SpecifiedSubstance                                                                                     // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. MedicinalProductIngredient.substance
                    this.Substance = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Substance",                                                                                                 // MakerGen.cs:235
                        Path= "MedicinalProductIngredient.substance",                                                                       // MakerGen.cs:236
                        Id = "MedicinalProductIngredient.substance",                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Substance                                                                                              // MakerGen.cs:259
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
                Role.Write(sDef);                                                                                                           // MakerGen.cs:220
                AllergenicIndicator.Write(sDef);                                                                                            // MakerGen.cs:220
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:220
                SpecifiedSubstance.Write(sDef);                                                                                             // MakerGen.cs:220
                Substance.Write(sDef);                                                                                                      // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public MedicinalProductIngredient_Elements Elements { get; }                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public MedicinalProductIngredient()                                                                                                 // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new MedicinalProductIngredient_Elements();                                                                      // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
