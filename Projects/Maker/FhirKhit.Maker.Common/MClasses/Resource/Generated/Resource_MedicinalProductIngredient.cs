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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MedicinalProductIngredient'
    /// </summary>
    // 0. MedicinalProductIngredient
    public class Resource_MedicinalProductIngredient : FhirKhit.Maker.Common.Resource.Resource_DomainResource                               // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 5. MedicinalProductIngredient.specifiedSubstance
        public class Type_SpecifiedSubstance : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 9. MedicinalProductIngredient.specifiedSubstance.strength
            public class Type_Strength : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                public class Type_ReferenceStrength : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                    public ElementDefinitionInfo Element_Substance;                                                                         // MakerGen.cs:219
                    // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                    public ElementDefinitionInfo Element_Strength;                                                                          // MakerGen.cs:219
                    // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                    public ElementDefinitionInfo Element_StrengthLowLimit;                                                                  // MakerGen.cs:219
                    // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                    public ElementDefinitionInfo Element_MeasurementPoint;                                                                  // MakerGen.cs:219
                    // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                    public ElementDefinitionInfo Element_Country;                                                                           // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:394
                            Path = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                              // MakerGen.cs:395
                            ElementId = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength"                          // MakerGen.cs:396
                        });                                                                                                                 // MakerGen.cs:397
                        Element_Substance.Write(sDef);                                                                                      // MakerGen.cs:223
                        Element_Strength.Write(sDef);                                                                                       // MakerGen.cs:223
                        Element_StrengthLowLimit.Write(sDef);                                                                               // MakerGen.cs:223
                        Element_MeasurementPoint.Write(sDef);                                                                               // MakerGen.cs:223
                        Element_Country.Write(sDef);                                                                                        // MakerGen.cs:223
                    }                                                                                                                       // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                    public Type_ReferenceStrength()                                                                                         // MakerGen.cs:402
                    {                                                                                                                       // MakerGen.cs:403
                        {                                                                                                                   // MakerGen.cs:234
                            // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                            this.Element_Substance = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Substance",                                                                                 // MakerGen.cs:238
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",                 // MakerGen.cs:239
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",                  // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:318
                                    {                                                                                                       // MakerGen.cs:319
                                    }                                                                                                       // MakerGen.cs:322
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                            this.Element_Strength = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Strength",                                                                                  // MakerGen.cs:238
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",                  // MakerGen.cs:239
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",                   // MakerGen.cs:240
                                Min = 1,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                            this.Element_StrengthLowLimit = new ElementDefinitionInfo                                                       // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_StrengthLowLimit",                                                                          // MakerGen.cs:238
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",          // MakerGen.cs:239
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",           // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                            this.Element_MeasurementPoint = new ElementDefinitionInfo                                                       // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_MeasurementPoint",                                                                          // MakerGen.cs:238
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",          // MakerGen.cs:239
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",           // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:303
                                    {                                                                                                       // MakerGen.cs:304
                                    }                                                                                                       // MakerGen.cs:307
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                            this.Element_Country = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Country",                                                                                   // MakerGen.cs:238
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",                   // MakerGen.cs:239
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",                    // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = -1,                                                                                                   // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:318
                                    {                                                                                                       // MakerGen.cs:319
                                    }                                                                                                       // MakerGen.cs:322
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:407
                // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                public ElementDefinitionInfo Element_Presentation;                                                                          // MakerGen.cs:219
                // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                public ElementDefinitionInfo Element_PresentationLowLimit;                                                                  // MakerGen.cs:219
                // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                public ElementDefinitionInfo Element_Concentration;                                                                         // MakerGen.cs:219
                // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                public ElementDefinitionInfo Element_ConcentrationLowLimit;                                                                 // MakerGen.cs:219
                // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                public ElementDefinitionInfo Element_MeasurementPoint;                                                                      // MakerGen.cs:219
                // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                public ElementDefinitionInfo Element_Country;                                                                               // MakerGen.cs:219
                // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                public ElementDefinitionInfo Element_ReferenceStrength;                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MedicinalProductIngredient.specifiedSubstance.strength",                                                    // MakerGen.cs:395
                        ElementId = "MedicinalProductIngredient.specifiedSubstance.strength"                                                // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Presentation.Write(sDef);                                                                                       // MakerGen.cs:223
                    Element_PresentationLowLimit.Write(sDef);                                                                               // MakerGen.cs:223
                    Element_Concentration.Write(sDef);                                                                                      // MakerGen.cs:223
                    Element_ConcentrationLowLimit.Write(sDef);                                                                              // MakerGen.cs:223
                    Element_MeasurementPoint.Write(sDef);                                                                                   // MakerGen.cs:223
                    Element_Country.Write(sDef);                                                                                            // MakerGen.cs:223
                    Element_ReferenceStrength.Write(sDef);                                                                                  // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Strength()                                                                                                      // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                        this.Element_Presentation = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Presentation",                                                                                  // MakerGen.cs:238
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                                    // MakerGen.cs:239
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                                     // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                        this.Element_PresentationLowLimit = new ElementDefinitionInfo                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_PresentationLowLimit",                                                                          // MakerGen.cs:238
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                            // MakerGen.cs:239
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                             // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                        this.Element_Concentration = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Concentration",                                                                                 // MakerGen.cs:238
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                                   // MakerGen.cs:239
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                                    // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                        this.Element_ConcentrationLowLimit = new ElementDefinitionInfo                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_ConcentrationLowLimit",                                                                         // MakerGen.cs:238
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",                           // MakerGen.cs:239
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",                            // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                        this.Element_MeasurementPoint = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_MeasurementPoint",                                                                              // MakerGen.cs:238
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",                                // MakerGen.cs:239
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",                                 // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                        this.Element_Country = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Country",                                                                                       // MakerGen.cs:238
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.country",                                         // MakerGen.cs:239
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.country",                                          // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                        this.Element_ReferenceStrength = new ElementDefinitionInfo                                                          // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_ReferenceStrength",                                                                             // MakerGen.cs:238
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                               // MakerGen.cs:239
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                                // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new Type_ReferenceStrength                                                                                  // MakerGen.cs:262
                                {                                                                                                           // MakerGen.cs:263
                                }                                                                                                           // MakerGen.cs:264
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 6. MedicinalProductIngredient.specifiedSubstance.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 7. MedicinalProductIngredient.specifiedSubstance.group
            public ElementDefinitionInfo Element_Group;                                                                                     // MakerGen.cs:219
            // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
            public ElementDefinitionInfo Element_Confidentiality;                                                                           // MakerGen.cs:219
            // 9. MedicinalProductIngredient.specifiedSubstance.strength
            public ElementDefinitionInfo Element_Strength;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicinalProductIngredient.specifiedSubstance",                                                                 // MakerGen.cs:395
                    ElementId = "MedicinalProductIngredient.specifiedSubstance"                                                             // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Group.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Confidentiality.Write(sDef);                                                                                        // MakerGen.cs:223
                Element_Strength.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_SpecifiedSubstance()                                                                                                // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 6. MedicinalProductIngredient.specifiedSubstance.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "MedicinalProductIngredient.specifiedSubstance.code",                                                         // MakerGen.cs:239
                        Id = "MedicinalProductIngredient.specifiedSubstance.code",                                                          // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
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
                    // 7. MedicinalProductIngredient.specifiedSubstance.group
                    this.Element_Group = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Group",                                                                                             // MakerGen.cs:238
                        Path= "MedicinalProductIngredient.specifiedSubstance.group",                                                        // MakerGen.cs:239
                        Id = "MedicinalProductIngredient.specifiedSubstance.group",                                                         // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
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
                    // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                    this.Element_Confidentiality = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Confidentiality",                                                                                   // MakerGen.cs:238
                        Path= "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                              // MakerGen.cs:239
                        Id = "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                               // MakerGen.cs:240
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
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    this.Element_Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Strength",                                                                                          // MakerGen.cs:238
                        Path= "MedicinalProductIngredient.specifiedSubstance.strength",                                                     // MakerGen.cs:239
                        Id = "MedicinalProductIngredient.specifiedSubstance.strength",                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Strength                                                                                               // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 22. MedicinalProductIngredient.substance
        public class Type_Substance : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 23. MedicinalProductIngredient.substance.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 24. MedicinalProductIngredient.substance.strength
            public ElementDefinitionInfo Element_Strength;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicinalProductIngredient.substance",                                                                          // MakerGen.cs:395
                    ElementId = "MedicinalProductIngredient.substance"                                                                      // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Strength.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Substance()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 23. MedicinalProductIngredient.substance.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "MedicinalProductIngredient.substance.code",                                                                  // MakerGen.cs:239
                        Id = "MedicinalProductIngredient.substance.code",                                                                   // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
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
                    // 24. MedicinalProductIngredient.substance.strength
                    this.Element_Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Strength",                                                                                          // MakerGen.cs:238
                        Path= "MedicinalProductIngredient.substance.strength",                                                              // MakerGen.cs:239
                        Id = "MedicinalProductIngredient.substance.strength",                                                               // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. MedicinalProductIngredient.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. MedicinalProductIngredient.role
        public ElementDefinitionInfo Element_Role;                                                                                          // MakerGen.cs:219
        // 3. MedicinalProductIngredient.allergenicIndicator
        public ElementDefinitionInfo Element_AllergenicIndicator;                                                                           // MakerGen.cs:219
        // 4. MedicinalProductIngredient.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;                                                                                  // MakerGen.cs:219
        // 5. MedicinalProductIngredient.specifiedSubstance
        public ElementDefinitionInfo Element_SpecifiedSubstance;                                                                            // MakerGen.cs:219
        // 22. MedicinalProductIngredient.substance
        public ElementDefinitionInfo Element_Substance;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MedicinalProductIngredient",                                                                                        // MakerGen.cs:395
                ElementId = "MedicinalProductIngredient"                                                                                    // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Role.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_AllergenicIndicator.Write(sDef);                                                                                        // MakerGen.cs:223
            Element_Manufacturer.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_SpecifiedSubstance.Write(sDef);                                                                                         // MakerGen.cs:223
            Element_Substance.Write(sDef);                                                                                                  // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MedicinalProductIngredient()                                                                                        // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MedicinalProductIngredient.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "MedicinalProductIngredient.identifier",                                                                          // MakerGen.cs:239
                    Id = "MedicinalProductIngredient.identifier",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. MedicinalProductIngredient.role
                this.Element_Role = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Role",                                                                                                  // MakerGen.cs:238
                    Path= "MedicinalProductIngredient.role",                                                                                // MakerGen.cs:239
                    Id = "MedicinalProductIngredient.role",                                                                                 // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
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
                // 3. MedicinalProductIngredient.allergenicIndicator
                this.Element_AllergenicIndicator = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AllergenicIndicator",                                                                                   // MakerGen.cs:238
                    Path= "MedicinalProductIngredient.allergenicIndicator",                                                                 // MakerGen.cs:239
                    Id = "MedicinalProductIngredient.allergenicIndicator",                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
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
                // 4. MedicinalProductIngredient.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:238
                    Path= "MedicinalProductIngredient.manufacturer",                                                                        // MakerGen.cs:239
                    Id = "MedicinalProductIngredient.manufacturer",                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. MedicinalProductIngredient.specifiedSubstance
                this.Element_SpecifiedSubstance = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SpecifiedSubstance",                                                                                    // MakerGen.cs:238
                    Path= "MedicinalProductIngredient.specifiedSubstance",                                                                  // MakerGen.cs:239
                    Id = "MedicinalProductIngredient.specifiedSubstance",                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_SpecifiedSubstance                                                                                         // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 22. MedicinalProductIngredient.substance
                this.Element_Substance = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Substance",                                                                                             // MakerGen.cs:238
                    Path= "MedicinalProductIngredient.substance",                                                                           // MakerGen.cs:239
                    Id = "MedicinalProductIngredient.substance",                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Substance                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MedicinalProductIngredient";                                                                                       // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient";                                                // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
