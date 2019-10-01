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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'MedicinalProductIngredient'
    /// </summary>
    // 0. MedicinalProductIngredient
    public class Resource_MedicinalProductIngredient : FhirKhit.Maker.Common.Resource.ResourceBase                                          // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_MedicinalProductIngredient_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 5. MedicinalProductIngredient.specifiedSubstance
            public class Type_SpecifiedSubstance : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_SpecifiedSubstance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    public class Type_Strength : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Strength_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                            public class Type_ReferenceStrength : FhirKhit.Maker.Common.Complex.ComplexBase                                 // MakerGen.cs:376
                            {                                                                                                               // MakerGen.cs:377
                                public class Type_ReferenceStrength_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                  // MakerGen.cs:378
                                {                                                                                                           // MakerGen.cs:379
                                    // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                                    public ElementDefinitionInfo Element_Substance;                                                         // MakerGen.cs:211
                                    // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                                    public ElementDefinitionInfo Element_Strength;                                                          // MakerGen.cs:211
                                    // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                                    public ElementDefinitionInfo Element_StrengthLowLimit;                                                  // MakerGen.cs:211
                                    // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                                    public ElementDefinitionInfo Element_MeasurementPoint;                                                  // MakerGen.cs:211
                                    // 21. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country
                                    public ElementDefinitionInfo Element_Country;                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                                    public Type_ReferenceStrength_Elements()                                                                // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:226
                                            // 17. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance
                                            this.Element_Substance = new ElementDefinitionInfo                                              // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Substance",                                                                 // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance", // MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.substance",  // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                  // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 18. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength
                                            this.Element_Strength = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Strength",                                                                  // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",  // MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strength",   // MakerGen.cs:232
                                                Min = 1,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_Ratio                                            // MakerGen.cs:350
                                                    {                                                                                       // MakerGen.cs:351
                                                    }                                                                                       // MakerGen.cs:352
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 19. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit
                                            this.Element_StrengthLowLimit = new ElementDefinitionInfo                                       // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_StrengthLowLimit",                                                          // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",// MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.strengthLowLimit",// MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_Ratio                                            // MakerGen.cs:350
                                                    {                                                                                       // MakerGen.cs:351
                                                    }                                                                                       // MakerGen.cs:352
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 20. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.measurementPoint
                                            this.Element_MeasurementPoint = new ElementDefinitionInfo                                       // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_MeasurementPoint",                                                          // MakerGen.cs:230
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
                                            this.Element_Country = new ElementDefinitionInfo                                                // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Country",                                                                   // MakerGen.cs:230
                                                Path= "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",   // MakerGen.cs:231
                                                Id = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength.country",    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                  // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:390
                                    {                                                                                                       // MakerGen.cs:391
                                        base.Write(sDef);                                                                                   // MakerGen.cs:392
                                        Element_Substance.Write(sDef);                                                                      // MakerGen.cs:215
                                        Element_Strength.Write(sDef);                                                                       // MakerGen.cs:215
                                        Element_StrengthLowLimit.Write(sDef);                                                               // MakerGen.cs:215
                                        Element_MeasurementPoint.Write(sDef);                                                               // MakerGen.cs:215
                                        Element_Country.Write(sDef);                                                                        // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:394
                                }                                                                                                           // MakerGen.cs:396
                                public Type_ReferenceStrength_Elements Elements                                                             // MakerGen.cs:398
                                {                                                                                                           // MakerGen.cs:399
                                    get                                                                                                     // MakerGen.cs:400
                                    {                                                                                                       // MakerGen.cs:401
                                        if (this.elements == null)                                                                          // MakerGen.cs:402
                                            this.elements = new Type_ReferenceStrength_Elements();                                          // MakerGen.cs:403
                                        return this.elements;                                                                               // MakerGen.cs:404
                                    }                                                                                                       // MakerGen.cs:405
                                }                                                                                                           // MakerGen.cs:406
                                Type_ReferenceStrength_Elements elements;                                                                   // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                                public Type_ReferenceStrength()                                                                             // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:411
                                }                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:416
                                {                                                                                                           // MakerGen.cs:417
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:418
                                    {                                                                                                       // MakerGen.cs:419
                                        Path = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength",                  // MakerGen.cs:420
                                        ElementId = "MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength"              // MakerGen.cs:421
                                    });                                                                                                     // MakerGen.cs:422
                                    if (this.elements != null)                                                                              // MakerGen.cs:423
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:424
                                }                                                                                                           // MakerGen.cs:425
                            }                                                                                                               // MakerGen.cs:426
                            // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                            public ElementDefinitionInfo Element_Presentation;                                                              // MakerGen.cs:211
                            // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                            public ElementDefinitionInfo Element_PresentationLowLimit;                                                      // MakerGen.cs:211
                            // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                            public ElementDefinitionInfo Element_Concentration;                                                             // MakerGen.cs:211
                            // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                            public ElementDefinitionInfo Element_ConcentrationLowLimit;                                                     // MakerGen.cs:211
                            // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                            public ElementDefinitionInfo Element_MeasurementPoint;                                                          // MakerGen.cs:211
                            // 15. MedicinalProductIngredient.specifiedSubstance.strength.country
                            public ElementDefinitionInfo Element_Country;                                                                   // MakerGen.cs:211
                            // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                            public ElementDefinitionInfo Element_ReferenceStrength;                                                         // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Strength_Elements()                                                                                 // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 10. MedicinalProductIngredient.specifiedSubstance.strength.presentation
                                    this.Element_Presentation = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Presentation",                                                                      // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                        // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentation",                         // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                    // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 11. MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit
                                    this.Element_PresentationLowLimit = new ElementDefinitionInfo                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_PresentationLowLimit",                                                              // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.presentationLowLimit",                 // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                    // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 12. MedicinalProductIngredient.specifiedSubstance.strength.concentration
                                    this.Element_Concentration = new ElementDefinitionInfo                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Concentration",                                                                     // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                       // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentration",                        // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                    // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 13. MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit
                                    this.Element_ConcentrationLowLimit = new ElementDefinitionInfo                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_ConcentrationLowLimit",                                                             // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",               // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.concentrationLowLimit",                // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                    // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 14. MedicinalProductIngredient.specifiedSubstance.strength.measurementPoint
                                    this.Element_MeasurementPoint = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_MeasurementPoint",                                                                  // MakerGen.cs:230
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
                                    this.Element_Country = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Country",                                                                           // MakerGen.cs:230
                                        Path= "MedicinalProductIngredient.specifiedSubstance.strength.country",                             // MakerGen.cs:231
                                        Id = "MedicinalProductIngredient.specifiedSubstance.strength.country",                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 16. MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength
                                    this.Element_ReferenceStrength = new ElementDefinitionInfo                                              // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_ReferenceStrength",                                                                 // MakerGen.cs:230
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
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_Presentation.Write(sDef);                                                                           // MakerGen.cs:215
                                Element_PresentationLowLimit.Write(sDef);                                                                   // MakerGen.cs:215
                                Element_Concentration.Write(sDef);                                                                          // MakerGen.cs:215
                                Element_ConcentrationLowLimit.Write(sDef);                                                                  // MakerGen.cs:215
                                Element_MeasurementPoint.Write(sDef);                                                                       // MakerGen.cs:215
                                Element_Country.Write(sDef);                                                                                // MakerGen.cs:215
                                Element_ReferenceStrength.Write(sDef);                                                                      // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Strength_Elements Elements                                                                              // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Strength_Elements();                                                           // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Strength_Elements elements;                                                                                    // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Strength()                                                                                              // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "MedicinalProductIngredient.specifiedSubstance.strength",                                            // MakerGen.cs:420
                                ElementId = "MedicinalProductIngredient.specifiedSubstance.strength"                                        // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 6. MedicinalProductIngredient.specifiedSubstance.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:211
                    // 7. MedicinalProductIngredient.specifiedSubstance.group
                    public ElementDefinitionInfo Element_Group;                                                                             // MakerGen.cs:211
                    // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                    public ElementDefinitionInfo Element_Confidentiality;                                                                   // MakerGen.cs:211
                    // 9. MedicinalProductIngredient.specifiedSubstance.strength
                    public ElementDefinitionInfo Element_Strength;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_SpecifiedSubstance_Elements()                                                                               // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 6. MedicinalProductIngredient.specifiedSubstance.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Code",                                                                                      // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.specifiedSubstance.code",                                                 // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.specifiedSubstance.code",                                                  // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. MedicinalProductIngredient.specifiedSubstance.group
                            this.Element_Group = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Group",                                                                                     // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.specifiedSubstance.group",                                                // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.specifiedSubstance.group",                                                 // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 8. MedicinalProductIngredient.specifiedSubstance.confidentiality
                            this.Element_Confidentiality = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Confidentiality",                                                                           // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                      // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.specifiedSubstance.confidentiality",                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. MedicinalProductIngredient.specifiedSubstance.strength
                            this.Element_Strength = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Strength",                                                                                  // MakerGen.cs:230
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Group.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_Confidentiality.Write(sDef);                                                                                // MakerGen.cs:215
                        Element_Strength.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_SpecifiedSubstance_Elements Elements                                                                            // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_SpecifiedSubstance_Elements();                                                         // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_SpecifiedSubstance_Elements elements;                                                                                  // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_SpecifiedSubstance()                                                                                            // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MedicinalProductIngredient.specifiedSubstance",                                                             // MakerGen.cs:420
                        ElementId = "MedicinalProductIngredient.specifiedSubstance"                                                         // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 22. MedicinalProductIngredient.substance
            public class Type_Substance : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Substance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 23. MedicinalProductIngredient.substance.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:211
                    // 24. MedicinalProductIngredient.substance.strength
                    public ElementDefinitionInfo Element_Strength;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Substance_Elements()                                                                                        // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. MedicinalProductIngredient.substance.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Code",                                                                                      // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.substance.code",                                                          // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.substance.code",                                                           // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. MedicinalProductIngredient.substance.strength
                            this.Element_Strength = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Strength",                                                                                  // MakerGen.cs:230
                                Path= "MedicinalProductIngredient.substance.strength",                                                      // MakerGen.cs:231
                                Id = "MedicinalProductIngredient.substance.strength",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Strength.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Substance_Elements Elements                                                                                     // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Substance_Elements();                                                                  // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Substance_Elements elements;                                                                                           // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Substance()                                                                                                     // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MedicinalProductIngredient.substance",                                                                      // MakerGen.cs:420
                        ElementId = "MedicinalProductIngredient.substance"                                                                  // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. MedicinalProductIngredient.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. MedicinalProductIngredient.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:211
            // 3. MedicinalProductIngredient.allergenicIndicator
            public ElementDefinitionInfo Element_AllergenicIndicator;                                                                       // MakerGen.cs:211
            // 4. MedicinalProductIngredient.manufacturer
            public ElementDefinitionInfo Element_Manufacturer;                                                                              // MakerGen.cs:211
            // 5. MedicinalProductIngredient.specifiedSubstance
            public ElementDefinitionInfo Element_SpecifiedSubstance;                                                                        // MakerGen.cs:211
            // 22. MedicinalProductIngredient.substance
            public ElementDefinitionInfo Element_Substance;                                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_MedicinalProductIngredient_Elements()                                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. MedicinalProductIngredient.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.identifier",                                                                      // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.identifier",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. MedicinalProductIngredient.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Role",                                                                                              // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.role",                                                                            // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.role",                                                                             // MakerGen.cs:232
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
                    // 3. MedicinalProductIngredient.allergenicIndicator
                    this.Element_AllergenicIndicator = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_AllergenicIndicator",                                                                               // MakerGen.cs:230
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
                    this.Element_Manufacturer = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Manufacturer",                                                                                      // MakerGen.cs:230
                        Path= "MedicinalProductIngredient.manufacturer",                                                                    // MakerGen.cs:231
                        Id = "MedicinalProductIngredient.manufacturer",                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
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
                    // 5. MedicinalProductIngredient.specifiedSubstance
                    this.Element_SpecifiedSubstance = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_SpecifiedSubstance",                                                                                // MakerGen.cs:230
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
                    this.Element_Substance = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Substance",                                                                                         // MakerGen.cs:230
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
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_AllergenicIndicator.Write(sDef);                                                                                    // MakerGen.cs:215
                Element_Manufacturer.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_SpecifiedSubstance.Write(sDef);                                                                                     // MakerGen.cs:215
                Element_Substance.Write(sDef);                                                                                              // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_MedicinalProductIngredient_Elements Elements                                                                        // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_MedicinalProductIngredient_Elements();                                                     // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_MedicinalProductIngredient_Elements elements;                                                                              // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_MedicinalProductIngredient()                                                                                        // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "MedicinalProductIngredient";                                                                                       // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient";                                                // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "MedicinalProductIngredient",                                                                                        // MakerGen.cs:420
                ElementId = "MedicinalProductIngredient"                                                                                    // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
