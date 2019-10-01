using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'MedicinalProductIngredient'
    /// </summary>
    // 0. MedicinalProductIngredient
    public class Resource_MedicinalProductIngredient : FhirKhit.Maker.Common.Resource.ResourceBase                                          // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 5. MedicinalProductIngredient.specifiedSubstance
        public class Type_SpecifiedSubstance : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 9. MedicinalProductIngredient.specifiedSubstance.strength
            public class Type_Strength : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                public class Type_ReferenceStrength : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:376
                {                                                                                                                           // MakerGen.cs:377
                    // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                    public ElementDefinitionInfo Element_Substance;                                                                         // MakerGen.cs:212
                    // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                    public ElementDefinitionInfo Element_Strength;                                                                          // MakerGen.cs:212
                    // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                    public ElementDefinitionInfo Element_StrengthLowLimit;                                                                  // MakerGen.cs:212
                    // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                    public ElementDefinitionInfo Element_MeasurementPoint;                                                                  // MakerGen.cs:212
                    // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                    public ElementDefinitionInfo Element_Country;                                                                           // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        base.Write(sDef);                                                                                                   // MakerGen.cs:385
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            Path = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                              // MakerGen.cs:388
                            ElementId = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength"                          // MakerGen.cs:389
                        });                                                                                                                 // MakerGen.cs:390
                        Element_Substance.Write(sDef);                                                                                      // MakerGen.cs:216
                        Element_Strength.Write(sDef);                                                                                       // MakerGen.cs:216
                        Element_StrengthLowLimit.Write(sDef);                                                                               // MakerGen.cs:216
                        Element_MeasurementPoint.Write(sDef);                                                                               // MakerGen.cs:216
                        Element_Country.Write(sDef);                                                                                        // MakerGen.cs:216
                    }                                                                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                    public Type_ReferenceStrength()                                                                                         // MakerGen.cs:395
                    {                                                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:227
                            // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                            this.Element_Substance = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Substance",                                                                                 // MakerGen.cs:231
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",                 // MakerGen.cs:232
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",                  // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:311
                                    {                                                                                                       // MakerGen.cs:312
                                    }                                                                                                       // MakerGen.cs:315
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                            this.Element_Strength = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Strength",                                                                                  // MakerGen.cs:231
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",                  // MakerGen.cs:232
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",                   // MakerGen.cs:233
                                Min = 1,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio                                                            // MakerGen.cs:351
                                    {                                                                                                       // MakerGen.cs:352
                                    }                                                                                                       // MakerGen.cs:353
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                            this.Element_StrengthLowLimit = new ElementDefinitionInfo                                                       // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_StrengthLowLimit",                                                                          // MakerGen.cs:231
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",          // MakerGen.cs:232
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",           // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio                                                            // MakerGen.cs:351
                                    {                                                                                                       // MakerGen.cs:352
                                    }                                                                                                       // MakerGen.cs:353
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                            this.Element_MeasurementPoint = new ElementDefinitionInfo                                                       // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_MeasurementPoint",                                                                          // MakerGen.cs:231
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",          // MakerGen.cs:232
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",           // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    }                                                                                                       // MakerGen.cs:300
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                            this.Element_Country = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Country",                                                                                   // MakerGen.cs:231
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",                   // MakerGen.cs:232
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",                    // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = -1,                                                                                                   // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:311
                                    {                                                                                                       // MakerGen.cs:312
                                    }                                                                                                       // MakerGen.cs:315
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                    }                                                                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:400
                // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                public ElementDefinitionInfo Element_Presentation;                                                                          // MakerGen.cs:212
                // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                public ElementDefinitionInfo Element_PresentationLowLimit;                                                                  // MakerGen.cs:212
                // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                public ElementDefinitionInfo Element_Concentration;                                                                         // MakerGen.cs:212
                // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                public ElementDefinitionInfo Element_ConcentrationLowLimit;                                                                 // MakerGen.cs:212
                // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                public ElementDefinitionInfo Element_MeasurementPoint;                                                                      // MakerGen.cs:212
                // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                public ElementDefinitionInfo Element_Country;                                                                               // MakerGen.cs:212
                // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                public ElementDefinitionInfo Element_ReferenceStrength;                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "MedicinalProductIngredient.specifiedSubstance.strength",                                                    // MakerGen.cs:388
                        ElementId = "MedicinalProductIngredient.specifiedSubstance.strength"                                                // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Presentation.Write(sDef);                                                                                       // MakerGen.cs:216
                    Element_PresentationLowLimit.Write(sDef);                                                                               // MakerGen.cs:216
                    Element_Concentration.Write(sDef);                                                                                      // MakerGen.cs:216
                    Element_ConcentrationLowLimit.Write(sDef);                                                                              // MakerGen.cs:216
                    Element_MeasurementPoint.Write(sDef);                                                                                   // MakerGen.cs:216
                    Element_Country.Write(sDef);                                                                                            // MakerGen.cs:216
                    Element_ReferenceStrength.Write(sDef);                                                                                  // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Strength()                                                                                                      // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                        this.Element_Presentation = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Presentation",                                                                                  // MakerGen.cs:231
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                                    // MakerGen.cs:232
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                                     // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                        this.Element_PresentationLowLimit = new ElementDefinitionInfo                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_PresentationLowLimit",                                                                          // MakerGen.cs:231
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                            // MakerGen.cs:232
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                             // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                        this.Element_Concentration = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Concentration",                                                                                 // MakerGen.cs:231
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                                   // MakerGen.cs:232
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                                    // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                        this.Element_ConcentrationLowLimit = new ElementDefinitionInfo                                                      // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_ConcentrationLowLimit",                                                                         // MakerGen.cs:231
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",                           // MakerGen.cs:232
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",                            // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                        this.Element_MeasurementPoint = new ElementDefinitionInfo                                                           // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_MeasurementPoint",                                                                              // MakerGen.cs:231
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",                                // MakerGen.cs:232
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",                                 // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                        this.Element_Country = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Country",                                                                                       // MakerGen.cs:231
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.country",                                         // MakerGen.cs:232
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.country",                                          // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                        this.Element_ReferenceStrength = new ElementDefinitionInfo                                                          // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_ReferenceStrength",                                                                             // MakerGen.cs:231
                            Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                               // MakerGen.cs:232
                            Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                                // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new Type_ReferenceStrength                                                                                  // MakerGen.cs:255
                                {                                                                                                           // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:257
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 6. MedicinalProductIngredient.specifiedSubstance.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:212
            // 7. MedicinalProductIngredient.specifiedSubstance.group
            public ElementDefinitionInfo Element_Group;                                                                                     // MakerGen.cs:212
            // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
            public ElementDefinitionInfo Element_Confidentiality;                                                                           // MakerGen.cs:212
            // 9. MedicinalProductIngredient.specifiedSubstance.strength
            public ElementDefinitionInfo Element_Strength;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicinalProductIngredient.specifiedSubstance",                                                                 // MakerGen.cs:388
                    ElementId = "MedicinalProductIngredient.specifiedSubstance"                                                             // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Group.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Confidentiality.Write(sDef);                                                                                        // MakerGen.cs:216
                Element_Strength.Write(sDef);                                                                                               // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_SpecifiedSubstance()                                                                                                // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 6. MedicinalProductIngredient.specifiedSubstance.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Code",                                                                                              // MakerGen.cs:231
                        Path= "MedicinalProductIngredient.specifiedSubstance.code",                                                         // MakerGen.cs:232
                        Id = "MedicinalProductIngredient.specifiedSubstance.code",                                                          // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 7. MedicinalProductIngredient.specifiedSubstance.group
                    this.Element_Group = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Group",                                                                                             // MakerGen.cs:231
                        Path= "MedicinalProductIngredient.specifiedSubstance.group",                                                        // MakerGen.cs:232
                        Id = "MedicinalProductIngredient.specifiedSubstance.group",                                                         // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                    this.Element_Confidentiality = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Confidentiality",                                                                                   // MakerGen.cs:231
                        Path= "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                              // MakerGen.cs:232
                        Id = "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    this.Element_Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Strength",                                                                                          // MakerGen.cs:231
                        Path= "MedicinalProductIngredient.specifiedSubstance.strength",                                                     // MakerGen.cs:232
                        Id = "MedicinalProductIngredient.specifiedSubstance.strength",                                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Strength                                                                                               // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 22. MedicinalProductIngredient.substance
        public class Type_Substance : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 23. MedicinalProductIngredient.substance.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:212
            // 24. MedicinalProductIngredient.substance.strength
            public ElementDefinitionInfo Element_Strength;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicinalProductIngredient.substance",                                                                          // MakerGen.cs:388
                    ElementId = "MedicinalProductIngredient.substance"                                                                      // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Strength.Write(sDef);                                                                                               // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Substance()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 23. MedicinalProductIngredient.substance.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Code",                                                                                              // MakerGen.cs:231
                        Path= "MedicinalProductIngredient.substance.code",                                                                  // MakerGen.cs:232
                        Id = "MedicinalProductIngredient.substance.code",                                                                   // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 24. MedicinalProductIngredient.substance.strength
                    this.Element_Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Strength",                                                                                          // MakerGen.cs:231
                        Path= "MedicinalProductIngredient.substance.strength",                                                              // MakerGen.cs:232
                        Id = "MedicinalProductIngredient.substance.strength",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. MedicinalProductIngredient.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. MedicinalProductIngredient.role
        public ElementDefinitionInfo Element_Role;                                                                                          // MakerGen.cs:212
        // 3. MedicinalProductIngredient.allergenicIndicator
        public ElementDefinitionInfo Element_AllergenicIndicator;                                                                           // MakerGen.cs:212
        // 4. MedicinalProductIngredient.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;                                                                                  // MakerGen.cs:212
        // 5. MedicinalProductIngredient.specifiedSubstance
        public ElementDefinitionInfo Element_SpecifiedSubstance;                                                                            // MakerGen.cs:212
        // 22. MedicinalProductIngredient.substance
        public ElementDefinitionInfo Element_Substance;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "MedicinalProductIngredient",                                                                                        // MakerGen.cs:388
                ElementId = "MedicinalProductIngredient"                                                                                    // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Role.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_AllergenicIndicator.Write(sDef);                                                                                        // MakerGen.cs:216
            Element_Manufacturer.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_SpecifiedSubstance.Write(sDef);                                                                                         // MakerGen.cs:216
            Element_Substance.Write(sDef);                                                                                                  // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_MedicinalProductIngredient()                                                                                        // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. MedicinalProductIngredient.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "MedicinalProductIngredient.identifier",                                                                          // MakerGen.cs:232
                    Id = "MedicinalProductIngredient.identifier",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. MedicinalProductIngredient.role
                this.Element_Role = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Role",                                                                                                  // MakerGen.cs:231
                    Path= "MedicinalProductIngredient.role",                                                                                // MakerGen.cs:232
                    Id = "MedicinalProductIngredient.role",                                                                                 // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. MedicinalProductIngredient.allergenicIndicator
                this.Element_AllergenicIndicator = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_AllergenicIndicator",                                                                                   // MakerGen.cs:231
                    Path= "MedicinalProductIngredient.allergenicIndicator",                                                                 // MakerGen.cs:232
                    Id = "MedicinalProductIngredient.allergenicIndicator",                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. MedicinalProductIngredient.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:231
                    Path= "MedicinalProductIngredient.manufacturer",                                                                        // MakerGen.cs:232
                    Id = "MedicinalProductIngredient.manufacturer",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. MedicinalProductIngredient.specifiedSubstance
                this.Element_SpecifiedSubstance = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SpecifiedSubstance",                                                                                    // MakerGen.cs:231
                    Path= "MedicinalProductIngredient.specifiedSubstance",                                                                  // MakerGen.cs:232
                    Id = "MedicinalProductIngredient.specifiedSubstance",                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_SpecifiedSubstance                                                                                         // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 22. MedicinalProductIngredient.substance
                this.Element_Substance = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Substance",                                                                                             // MakerGen.cs:231
                    Path= "MedicinalProductIngredient.substance",                                                                           // MakerGen.cs:232
                    Id = "MedicinalProductIngredient.substance",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Substance                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "MedicinalProductIngredient";                                                                                       // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient";                                                // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
