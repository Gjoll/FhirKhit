using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'MedicinalProductIngredient'
    /// </summary>
    // 0. MedicinalProductIngredient
    public class MedicinalProductIngredient : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class MedicinalProductIngredient_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 5. MedicinalProductIngredient.specifiedSubstance
            public class Type_SpecifiedSubstance : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_SpecifiedSubstance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    public class Type_Strength : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Strength_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                            public class Type_ReferenceStrength : FhirKhit.Maker.Common.Complex.ComplexBase                                 // MakerGen.cs:379
                            {                                                                                                               // MakerGen.cs:380
                                public class Type_ReferenceStrength_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                  // MakerGen.cs:381
                                {                                                                                                           // MakerGen.cs:382
                                    // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                                    public ElementDefinitionInfo Substance;                                                                 // MakerGen.cs:211
                                    // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                                    public ElementDefinitionInfo Strength;                                                                  // MakerGen.cs:211
                                    // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                                    public ElementDefinitionInfo StrengthLowLimit;                                                          // MakerGen.cs:211
                                    // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                                    public ElementDefinitionInfo MeasurementPoint;                                                          // MakerGen.cs:211
                                    // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                                    public ElementDefinitionInfo Country;                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                                    public Type_ReferenceStrength_Elements()                                                                // MakerGen.cs:387
                                    {                                                                                                       // MakerGen.cs:388
                                        {                                                                                                   // MakerGen.cs:226
                                            // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                                            this.Substance = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Substance",                                                                         // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance", // MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",  // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                                            this.Strength = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Strength",                                                                          // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",  // MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",   // MakerGen.cs:232
                                                Min = 1,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Ratio                                                 // MakerGen.cs:353
                                                    {                                                                                       // MakerGen.cs:354
                                                    }                                                                                       // MakerGen.cs:355
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                                            this.StrengthLowLimit = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "StrengthLowLimit",                                                                  // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",// MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",// MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Ratio                                                 // MakerGen.cs:353
                                                    {                                                                                       // MakerGen.cs:354
                                                    }                                                                                       // MakerGen.cs:355
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                                            this.MeasurementPoint = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "MeasurementPoint",                                                                  // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",// MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint",// MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:295
                                                    {                                                                                       // MakerGen.cs:296
                                                    }                                                                                       // MakerGen.cs:299
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                                            this.Country = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Country",                                                                           // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",   // MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:393
                                    {                                                                                                       // MakerGen.cs:394
                                        base.Write(sDef);                                                                                   // MakerGen.cs:395
                                        Substance.Write(sDef);                                                                              // MakerGen.cs:215
                                        Strength.Write(sDef);                                                                               // MakerGen.cs:215
                                        StrengthLowLimit.Write(sDef);                                                                       // MakerGen.cs:215
                                        MeasurementPoint.Write(sDef);                                                                       // MakerGen.cs:215
                                        Country.Write(sDef);                                                                                // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:397
                                }                                                                                                           // MakerGen.cs:399
                                public Type_ReferenceStrength_Elements Elements                                                             // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    get                                                                                                     // MakerGen.cs:403
                                    {                                                                                                       // MakerGen.cs:404
                                        if (this.elements == null)                                                                          // MakerGen.cs:405
                                            this.elements = new Type_ReferenceStrength_Elements();                                          // MakerGen.cs:406
                                        return this.elements;                                                                               // MakerGen.cs:407
                                    }                                                                                                       // MakerGen.cs:408
                                }                                                                                                           // MakerGen.cs:409
                                Type_ReferenceStrength_Elements elements;                                                                   // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                                public Type_ReferenceStrength()                                                                             // MakerGen.cs:413
                                {                                                                                                           // MakerGen.cs:414
                                }                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:419
                                {                                                                                                           // MakerGen.cs:420
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:421
                                    {                                                                                                       // MakerGen.cs:422
                                        Path = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                  // MakerGen.cs:423
                                        ElementId = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength"              // MakerGen.cs:424
                                    });                                                                                                     // MakerGen.cs:425
                                    if (this.elements != null)                                                                              // MakerGen.cs:426
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:427
                                }                                                                                                           // MakerGen.cs:428
                            }                                                                                                               // MakerGen.cs:429
                            // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                            public ElementDefinitionInfo Presentation;                                                                      // MakerGen.cs:211
                            // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                            public ElementDefinitionInfo PresentationLowLimit;                                                              // MakerGen.cs:211
                            // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                            public ElementDefinitionInfo Concentration;                                                                     // MakerGen.cs:211
                            // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                            public ElementDefinitionInfo ConcentrationLowLimit;                                                             // MakerGen.cs:211
                            // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                            public ElementDefinitionInfo MeasurementPoint;                                                                  // MakerGen.cs:211
                            // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                            public ElementDefinitionInfo Country;                                                                           // MakerGen.cs:211
                            // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                            public ElementDefinitionInfo ReferenceStrength;                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Strength_Elements()                                                                                 // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                                    this.Presentation = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Presentation",                                                                              // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                        // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                         // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Ratio                                                         // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                                    this.PresentationLowLimit = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "PresentationLowLimit",                                                                      // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                 // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Ratio                                                         // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                                    this.Concentration = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Concentration",                                                                             // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                       // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                        // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Ratio                                                         // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                                    this.ConcentrationLowLimit = new ElementDefinitionInfo                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "ConcentrationLowLimit",                                                                     // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",               // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",                // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Ratio                                                         // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                                    this.MeasurementPoint = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "MeasurementPoint",                                                                          // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",                    // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint",                     // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                                    this.Country = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Country",                                                                                   // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.country",                             // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.country",                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                                    this.ReferenceStrength = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "ReferenceStrength",                                                                         // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                   // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_ReferenceStrength                                                                      // MakerGen.cs:254
                                            {                                                                                               // MakerGen.cs:255
                                            }                                                                                               // MakerGen.cs:256
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Presentation.Write(sDef);                                                                                   // MakerGen.cs:215
                                PresentationLowLimit.Write(sDef);                                                                           // MakerGen.cs:215
                                Concentration.Write(sDef);                                                                                  // MakerGen.cs:215
                                ConcentrationLowLimit.Write(sDef);                                                                          // MakerGen.cs:215
                                MeasurementPoint.Write(sDef);                                                                               // MakerGen.cs:215
                                Country.Write(sDef);                                                                                        // MakerGen.cs:215
                                ReferenceStrength.Write(sDef);                                                                              // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Strength_Elements Elements                                                                              // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Strength_Elements();                                                           // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Strength_Elements elements;                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Strength()                                                                                              // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "MedicinalProductIngredient.specifiedSubstance.strength",                                            // MakerGen.cs:423
                                ElementId = "MedicinalProductIngredient.specifiedSubstance.strength"                                        // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 6. MedicinalProductIngredient.specifiedSubstance.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 7. MedicinalProductIngredient.specifiedSubstance.group
                    public ElementDefinitionInfo Group;                                                                                     // MakerGen.cs:211
                    // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                    public ElementDefinitionInfo Confidentiality;                                                                           // MakerGen.cs:211
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    public ElementDefinitionInfo Strength;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_SpecifiedSubstance_Elements()                                                                               // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 6. MedicinalProductIngredient.specifiedSubstance.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.specifiedSubstance.code",                                                 // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.specifiedSubstance.code",                                                  // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. MedicinalProductIngredient.specifiedSubstance.group
                            this.Group = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Group",                                                                                             // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.specifiedSubstance.group",                                                // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.specifiedSubstance.group",                                                 // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                            this.Confidentiality = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Confidentiality",                                                                                   // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                      // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. MedicinalProductIngredient.specifiedSubstance.strength
                            this.Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Strength",                                                                                          // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.specifiedSubstance.strength",                                             // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.specifiedSubstance.strength",                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Strength                                                                                       // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Group.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Confidentiality.Write(sDef);                                                                                        // MakerGen.cs:215
                        Strength.Write(sDef);                                                                                               // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_SpecifiedSubstance_Elements Elements                                                                            // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_SpecifiedSubstance_Elements();                                                         // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_SpecifiedSubstance_Elements elements;                                                                                  // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_SpecifiedSubstance()                                                                                            // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "MedicinalProductIngredient.specifiedSubstance",                                                             // MakerGen.cs:423
                        ElementId = "MedicinalProductIngredient.specifiedSubstance"                                                         // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 22. MedicinalProductIngredient.substance
            public class Type_Substance : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Substance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 23. MedicinalProductIngredient.substance.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 24. MedicinalProductIngredient.substance.strength
                    public ElementDefinitionInfo Strength;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Substance_Elements()                                                                                        // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. MedicinalProductIngredient.substance.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.substance.code",                                                          // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.substance.code",                                                           // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. MedicinalProductIngredient.substance.strength
                            this.Strength = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Strength",                                                                                          // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.substance.strength",                                                      // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.substance.strength",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Strength.Write(sDef);                                                                                               // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Substance_Elements Elements                                                                                     // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Substance_Elements();                                                                  // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Substance_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Substance()                                                                                                     // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "MedicinalProductIngredient.substance",                                                                      // MakerGen.cs:423
                        ElementId = "MedicinalProductIngredient.substance"                                                                  // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. MedicinalProductIngredient.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. MedicinalProductIngredient.role
            public ElementDefinitionInfo Role;                                                                                              // MakerGen.cs:211
            // 3. MedicinalProductIngredient.allergenicIndicator
            public ElementDefinitionInfo AllergenicIndicator;                                                                               // MakerGen.cs:211
            // 4. MedicinalProductIngredient.manufacturer
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:211
            // 5. MedicinalProductIngredient.specifiedSubstance
            public ElementDefinitionInfo SpecifiedSubstance;                                                                                // MakerGen.cs:211
            // 22. MedicinalProductIngredient.substance
            public ElementDefinitionInfo Substance;                                                                                         // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public MedicinalProductIngredient_Elements()                                                                                    // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. MedicinalProductIngredient.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.identifier",                                                                      // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.identifier",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. MedicinalProductIngredient.role
                    this.Role = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Role",                                                                                                      // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.role",                                                                            // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.role",                                                                             // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. MedicinalProductIngredient.allergenicIndicator
                    this.AllergenicIndicator = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "AllergenicIndicator",                                                                                       // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.allergenicIndicator",                                                             // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.allergenicIndicator",                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. MedicinalProductIngredient.manufacturer
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.manufacturer",                                                                    // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.manufacturer",                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. MedicinalProductIngredient.specifiedSubstance
                    this.SpecifiedSubstance = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "SpecifiedSubstance",                                                                                        // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.specifiedSubstance",                                                              // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.specifiedSubstance",                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_SpecifiedSubstance                                                                                     // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. MedicinalProductIngredient.substance
                    this.Substance = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Substance",                                                                                                 // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.substance",                                                                       // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.substance",                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Substance                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Role.Write(sDef);                                                                                                           // MakerGen.cs:215
                AllergenicIndicator.Write(sDef);                                                                                            // MakerGen.cs:215
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:215
                SpecifiedSubstance.Write(sDef);                                                                                             // MakerGen.cs:215
                Substance.Write(sDef);                                                                                                      // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public MedicinalProductIngredient_Elements Elements                                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new MedicinalProductIngredient_Elements();                                                              // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        MedicinalProductIngredient_Elements elements;                                                                                       // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public MedicinalProductIngredient()                                                                                                 // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "MedicinalProductIngredient";                                                                                       // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient";                                                // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "MedicinalProductIngredient",                                                                                        // MakerGen.cs:423
                ElementId = "MedicinalProductIngredient"                                                                                    // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
