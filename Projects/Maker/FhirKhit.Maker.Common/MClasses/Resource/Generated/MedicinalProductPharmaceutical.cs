using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
    {
      "resourceType": "StructureDefinition",
      "id": "MedicinalProductPharmaceutical",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical",
      "version": "4.0.0",
      "name": "MedicinalProductPharmaceutical",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "A pharmaceutical product described in terms of its composition and dose form.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductPharmaceutical",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductPharmaceutical",
            "path": "MedicinalProductPharmaceutical",
            "short": "A pharmaceutical product described in terms of its composition and dose form",
            "definition": "A pharmaceutical product described in terms of its composition and dose form.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductPharmaceutical.identifier",
            "path": "MedicinalProductPharmaceutical.identifier",
            "short": "An identifier for the pharmaceutical medicinal product",
            "definition": "An identifier for the pharmaceutical medicinal product.",
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
            "id": "MedicinalProductPharmaceutical.administrableDoseForm",
            "path": "MedicinalProductPharmaceutical.administrableDoseForm",
            "short": "The administrable dose form, after necessary reconstitution",
            "definition": "The administrable dose form, after necessary reconstitution.",
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
            "id": "MedicinalProductPharmaceutical.unitOfPresentation",
            "path": "MedicinalProductPharmaceutical.unitOfPresentation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "MedicinalProductPharmaceutical.ingredient",
            "path": "MedicinalProductPharmaceutical.ingredient",
            "short": "Ingredient",
            "definition": "Ingredient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.device",
            "path": "MedicinalProductPharmaceutical.device",
            "short": "Accompanying device",
            "definition": "Accompanying device.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.characteristics",
            "path": "MedicinalProductPharmaceutical.characteristics",
            "short": "Characteristics e.g. a products onset of action",
            "definition": "Characteristics e.g. a products onset of action.",
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
            "id": "MedicinalProductPharmaceutical.characteristics.code",
            "path": "MedicinalProductPharmaceutical.characteristics.code",
            "short": "A coded characteristic",
            "definition": "A coded characteristic.",
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
            "id": "MedicinalProductPharmaceutical.characteristics.status",
            "path": "MedicinalProductPharmaceutical.characteristics.status",
            "short": "The status of characteristic e.g. assigned or pending",
            "definition": "The status of characteristic e.g. assigned or pending.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration",
            "short": "The path by which the pharmaceutical product is taken into or makes contact with the body",
            "definition": "The path by which the pharmaceutical product is taken into or makes contact with the body.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.code",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.code",
            "short": "Coded expression for the route",
            "definition": "Coded expression for the route.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",
            "short": "The first dose (dose quantity) administered in humans can be specified, for a product under investigation, using a numerical value and its unit of measurement",
            "definition": "The first dose (dose quantity) administered in humans can be specified, for a product under investigation, using a numerical value and its unit of measurement.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",
            "short": "The maximum single dose that can be administered as per the protocol of a clinical trial can be specified using a numerical value and its unit of measurement",
            "definition": "The maximum single dose that can be administered as per the protocol of a clinical trial can be specified using a numerical value and its unit of measurement.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",
            "short": "The maximum dose per day (maximum dose quantity to be administered in any one 24-h period) that can be administered as per the protocol referenced in the clinical trial authorisation",
            "definition": "The maximum dose per day (maximum dose quantity to be administered in any one 24-h period) that can be administered as per the protocol referenced in the clinical trial authorisation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",
            "short": "The maximum dose per treatment period that can be administered as per the protocol referenced in the clinical trial authorisation",
            "definition": "The maximum dose per treatment period that can be administered as per the protocol referenced in the clinical trial authorisation.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",
            "short": "The maximum treatment period during which an Investigational Medicinal Product can be administered as per the protocol referenced in the clinical trial authorisation",
            "definition": "The maximum treatment period during which an Investigational Medicinal Product can be administered as per the protocol referenced in the clinical trial authorisation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",
            "short": "A species for which this route applies",
            "definition": "A species for which this route applies.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",
            "short": "Coded expression for the species",
            "definition": "Coded expression for the species.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",
            "short": "A species specific time during which consumption of animal product is not appropriate",
            "definition": "A species specific time during which consumption of animal product is not appropriate.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",
            "short": "Coded expression for the type of tissue for which the withdrawal period applues, e.g. meat, milk",
            "definition": "Coded expression for the type of tissue for which the withdrawal period applues, e.g. meat, milk.",
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
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",
            "short": "A value for the time",
            "definition": "A value for the time.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",
            "path": "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",
            "short": "Extra information about the withdrawal period",
            "definition": "Extra information about the withdrawal period.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'MedicinalProductPharmaceutical'
    /// </summary>
    // 0. MedicinalProductPharmaceutical
    public class MedicinalProductPharmaceutical : FhirKhit.Maker.Common.Resource.ResourceBase                                               // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class MedicinalProductPharmaceutical_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 6. MedicinalProductPharmaceutical.characteristics
            public class Type_Characteristics : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Characteristics_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 7. MedicinalProductPharmaceutical.characteristics.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 8. MedicinalProductPharmaceutical.characteristics.status
                    public ElementDefinitionInfo Status;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Characteristics_Elements()                                                                                  // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 7. MedicinalProductPharmaceutical.characteristics.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.characteristics.code",                                                // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.characteristics.code",                                                 // MakerGen.cs:237
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
                            // 8. MedicinalProductPharmaceutical.characteristics.status
                            this.Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Status",                                                                                            // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.characteristics.status",                                              // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.characteristics.status",                                               // MakerGen.cs:237
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
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Status.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Characteristics_Elements Elements                                                                               // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Characteristics_Elements();                                                            // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Characteristics_Elements elements;                                                                                     // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Characteristics()                                                                                               // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MedicinalProductPharmaceutical.characteristics",                                                            // MakerGen.cs:428
                        ElementId = "MedicinalProductPharmaceutical.characteristics"                                                        // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 9. MedicinalProductPharmaceutical.routeOfAdministration
            public class Type_RouteOfAdministration : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_RouteOfAdministration_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                    public class Type_TargetSpecies : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_TargetSpecies_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                            public class Type_WithdrawalPeriod : FhirKhit.Maker.Common.Complex.ComplexBase                                  // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                public class Type_WithdrawalPeriod_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                   // MakerGen.cs:386
                                {                                                                                                           // MakerGen.cs:387
                                    // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                                    public ElementDefinitionInfo Tissue;                                                                    // MakerGen.cs:216
                                    // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                                    public ElementDefinitionInfo Value;                                                                     // MakerGen.cs:216
                                    // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                                    public ElementDefinitionInfo SupportingInformation;                                                     // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                    public Type_WithdrawalPeriod_Elements()                                                                 // MakerGen.cs:392
                                    {                                                                                                       // MakerGen.cs:393
                                        {                                                                                                   // MakerGen.cs:231
                                            // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                                            this.Tissue = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Tissue",                                                                            // MakerGen.cs:235
                                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",// MakerGen.cs:236
                                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",// MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
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
                                            // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                                            this.Value = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Value",                                                                             // MakerGen.cs:235
                                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",// MakerGen.cs:236
                                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",// MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                                            this.SupportingInformation = new ElementDefinitionInfo                                          // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "SupportingInformation",                                                             // MakerGen.cs:235
                                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",// MakerGen.cs:236
                                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",// MakerGen.cs:237
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
                                    }                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:398
                                    {                                                                                                       // MakerGen.cs:399
                                        base.Write(sDef);                                                                                   // MakerGen.cs:400
                                        Tissue.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Value.Write(sDef);                                                                                  // MakerGen.cs:220
                                        SupportingInformation.Write(sDef);                                                                  // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:402
                                }                                                                                                           // MakerGen.cs:404
                                public Type_WithdrawalPeriod_Elements Elements                                                              // MakerGen.cs:406
                                {                                                                                                           // MakerGen.cs:407
                                    get                                                                                                     // MakerGen.cs:408
                                    {                                                                                                       // MakerGen.cs:409
                                        if (this.elements == null)                                                                          // MakerGen.cs:410
                                            this.elements = new Type_WithdrawalPeriod_Elements();                                           // MakerGen.cs:411
                                        return this.elements;                                                                               // MakerGen.cs:412
                                    }                                                                                                       // MakerGen.cs:413
                                }                                                                                                           // MakerGen.cs:414
                                Type_WithdrawalPeriod_Elements elements;                                                                    // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                public Type_WithdrawalPeriod()                                                                              // MakerGen.cs:418
                                {                                                                                                           // MakerGen.cs:419
                                }                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:424
                                {                                                                                                           // MakerGen.cs:425
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:426
                                    {                                                                                                       // MakerGen.cs:427
                                        Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",       // MakerGen.cs:428
                                        ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod"   // MakerGen.cs:429
                                    });                                                                                                     // MakerGen.cs:430
                                    if (this.elements != null)                                                                              // MakerGen.cs:431
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:432
                                }                                                                                                           // MakerGen.cs:433
                            }                                                                                                               // MakerGen.cs:434
                            // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:216
                            // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                            public ElementDefinitionInfo WithdrawalPeriod;                                                                  // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_TargetSpecies_Elements()                                                                            // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Code",                                                                                      // MakerGen.cs:235
                                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",                    // MakerGen.cs:236
                                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",                     // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                                    this.WithdrawalPeriod = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "WithdrawalPeriod",                                                                          // MakerGen.cs:235
                                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",        // MakerGen.cs:236
                                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_WithdrawalPeriod                                                                       // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Code.Write(sDef);                                                                                           // MakerGen.cs:220
                                WithdrawalPeriod.Write(sDef);                                                                               // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_TargetSpecies_Elements Elements                                                                         // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_TargetSpecies_Elements();                                                      // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_TargetSpecies_Elements elements;                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_TargetSpecies()                                                                                         // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                // MakerGen.cs:428
                                ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies"                            // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
                    public ElementDefinitionInfo FirstDose;                                                                                 // MakerGen.cs:216
                    // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
                    public ElementDefinitionInfo MaxSingleDose;                                                                             // MakerGen.cs:216
                    // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
                    public ElementDefinitionInfo MaxDosePerDay;                                                                             // MakerGen.cs:216
                    // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
                    public ElementDefinitionInfo MaxDosePerTreatmentPeriod;                                                                 // MakerGen.cs:216
                    // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
                    public ElementDefinitionInfo MaxTreatmentPeriod;                                                                        // MakerGen.cs:216
                    // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                    public ElementDefinitionInfo TargetSpecies;                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_RouteOfAdministration_Elements()                                                                            // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.code",                                          // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.code",                                           // MakerGen.cs:237
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
                            // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
                            this.FirstDose = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "FirstDose",                                                                                         // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",                                     // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
                            this.MaxSingleDose = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "MaxSingleDose",                                                                                     // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",                                 // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
                            this.MaxDosePerDay = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "MaxDosePerDay",                                                                                     // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",                                 // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
                            this.MaxDosePerTreatmentPeriod = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "MaxDosePerTreatmentPeriod",                                                                         // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",                     // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
                            this.MaxTreatmentPeriod = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "MaxTreatmentPeriod",                                                                                // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",                            // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                            this.TargetSpecies = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "TargetSpecies",                                                                                     // MakerGen.cs:235
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                 // MakerGen.cs:236
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_TargetSpecies                                                                                  // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        FirstDose.Write(sDef);                                                                                              // MakerGen.cs:220
                        MaxSingleDose.Write(sDef);                                                                                          // MakerGen.cs:220
                        MaxDosePerDay.Write(sDef);                                                                                          // MakerGen.cs:220
                        MaxDosePerTreatmentPeriod.Write(sDef);                                                                              // MakerGen.cs:220
                        MaxTreatmentPeriod.Write(sDef);                                                                                     // MakerGen.cs:220
                        TargetSpecies.Write(sDef);                                                                                          // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_RouteOfAdministration_Elements Elements                                                                         // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_RouteOfAdministration_Elements();                                                      // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_RouteOfAdministration_Elements elements;                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_RouteOfAdministration()                                                                                         // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MedicinalProductPharmaceutical.routeOfAdministration",                                                      // MakerGen.cs:428
                        ElementId = "MedicinalProductPharmaceutical.routeOfAdministration"                                                  // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. MedicinalProductPharmaceutical.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. MedicinalProductPharmaceutical.administrableDoseForm
            public ElementDefinitionInfo AdministrableDoseForm;                                                                             // MakerGen.cs:216
            // 3. MedicinalProductPharmaceutical.unitOfPresentation
            public ElementDefinitionInfo UnitOfPresentation;                                                                                // MakerGen.cs:216
            // 4. MedicinalProductPharmaceutical.ingredient
            public ElementDefinitionInfo Ingredient;                                                                                        // MakerGen.cs:216
            // 5. MedicinalProductPharmaceutical.device
            public ElementDefinitionInfo Device;                                                                                            // MakerGen.cs:216
            // 6. MedicinalProductPharmaceutical.characteristics
            public ElementDefinitionInfo Characteristics;                                                                                   // MakerGen.cs:216
            // 9. MedicinalProductPharmaceutical.routeOfAdministration
            public ElementDefinitionInfo RouteOfAdministration;                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public MedicinalProductPharmaceutical_Elements()                                                                                // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicinalProductPharmaceutical.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "MedicinalProductPharmaceutical.identifier",                                                                  // MakerGen.cs:236
                        Id = "MedicinalProductPharmaceutical.identifier",                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MedicinalProductPharmaceutical.administrableDoseForm
                    this.AdministrableDoseForm = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AdministrableDoseForm",                                                                                     // MakerGen.cs:235
                        Path= "MedicinalProductPharmaceutical.administrableDoseForm",                                                       // MakerGen.cs:236
                        Id = "MedicinalProductPharmaceutical.administrableDoseForm",                                                        // MakerGen.cs:237
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
                    // 3. MedicinalProductPharmaceutical.unitOfPresentation
                    this.UnitOfPresentation = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UnitOfPresentation",                                                                                        // MakerGen.cs:235
                        Path= "MedicinalProductPharmaceutical.unitOfPresentation",                                                          // MakerGen.cs:236
                        Id = "MedicinalProductPharmaceutical.unitOfPresentation",                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 4. MedicinalProductPharmaceutical.ingredient
                    this.Ingredient = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Ingredient",                                                                                                // MakerGen.cs:235
                        Path= "MedicinalProductPharmaceutical.ingredient",                                                                  // MakerGen.cs:236
                        Id = "MedicinalProductPharmaceutical.ingredient",                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. MedicinalProductPharmaceutical.device
                    this.Device = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Device",                                                                                                    // MakerGen.cs:235
                        Path= "MedicinalProductPharmaceutical.device",                                                                      // MakerGen.cs:236
                        Id = "MedicinalProductPharmaceutical.device",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. MedicinalProductPharmaceutical.characteristics
                    this.Characteristics = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Characteristics",                                                                                           // MakerGen.cs:235
                        Path= "MedicinalProductPharmaceutical.characteristics",                                                             // MakerGen.cs:236
                        Id = "MedicinalProductPharmaceutical.characteristics",                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Characteristics                                                                                        // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. MedicinalProductPharmaceutical.routeOfAdministration
                    this.RouteOfAdministration = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RouteOfAdministration",                                                                                     // MakerGen.cs:235
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration",                                                       // MakerGen.cs:236
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration",                                                        // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_RouteOfAdministration                                                                                  // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                AdministrableDoseForm.Write(sDef);                                                                                          // MakerGen.cs:220
                UnitOfPresentation.Write(sDef);                                                                                             // MakerGen.cs:220
                Ingredient.Write(sDef);                                                                                                     // MakerGen.cs:220
                Device.Write(sDef);                                                                                                         // MakerGen.cs:220
                Characteristics.Write(sDef);                                                                                                // MakerGen.cs:220
                RouteOfAdministration.Write(sDef);                                                                                          // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public MedicinalProductPharmaceutical_Elements Elements                                                                             // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new MedicinalProductPharmaceutical_Elements();                                                          // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        MedicinalProductPharmaceutical_Elements elements;                                                                                   // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public MedicinalProductPharmaceutical()                                                                                             // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "MedicinalProductPharmaceutical";                                                                                   // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical";                                            // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "MedicinalProductPharmaceutical",                                                                                    // MakerGen.cs:428
                ElementId = "MedicinalProductPharmaceutical"                                                                                // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
