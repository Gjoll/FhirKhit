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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MedicinalProductPharmaceutical'
    /// </summary>
    // 0. MedicinalProductPharmaceutical
    public class Resource_MedicinalProductPharmaceutical : FhirKhit.Maker.Common.Resource.Resource_DomainResource                           // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 6. MedicinalProductPharmaceutical.characteristics
        public class Type_Characteristics : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 7. MedicinalProductPharmaceutical.characteristics.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 8. MedicinalProductPharmaceutical.characteristics.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicinalProductPharmaceutical.characteristics",                                                                // MakerGen.cs:395
                    ElementId = "MedicinalProductPharmaceutical.characteristics"                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Characteristics()                                                                                                   // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 7. MedicinalProductPharmaceutical.characteristics.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.characteristics.code",                                                        // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.characteristics.code",                                                         // MakerGen.cs:240
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
                    // 8. MedicinalProductPharmaceutical.characteristics.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Status",                                                                                            // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.characteristics.status",                                                      // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.characteristics.status",                                                       // MakerGen.cs:240
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
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 9. MedicinalProductPharmaceutical.routeOfAdministration
        public class Type_RouteOfAdministration : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
            public class Type_TargetSpecies : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                public class Type_WithdrawalPeriod : FhirKhit.Maker.Common.Complex.ComplexBase                                              // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                    public ElementDefinitionInfo Element_Tissue;                                                                            // MakerGen.cs:219
                    // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                    public ElementDefinitionInfo Element_Value;                                                                             // MakerGen.cs:219
                    // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                    public ElementDefinitionInfo Element_SupportingInformation;                                                             // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:394
                            Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",                   // MakerGen.cs:395
                            ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod"               // MakerGen.cs:396
                        });                                                                                                                 // MakerGen.cs:397
                        Element_Tissue.Write(sDef);                                                                                         // MakerGen.cs:223
                        Element_Value.Write(sDef);                                                                                          // MakerGen.cs:223
                        Element_SupportingInformation.Write(sDef);                                                                          // MakerGen.cs:223
                    }                                                                                                                       // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                    public Type_WithdrawalPeriod()                                                                                          // MakerGen.cs:402
                    {                                                                                                                       // MakerGen.cs:403
                        {                                                                                                                   // MakerGen.cs:234
                            // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                            this.Element_Tissue = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Tissue",                                                                                    // MakerGen.cs:238
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",         // MakerGen.cs:239
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",          // MakerGen.cs:240
                                Min = 1,                                                                                                    // MakerGen.cs:241
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
                            // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                            this.Element_Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Value",                                                                                     // MakerGen.cs:238
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",          // MakerGen.cs:239
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",           // MakerGen.cs:240
                                Min = 1,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                            this.Element_SupportingInformation = new ElementDefinitionInfo                                                  // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_SupportingInformation",                                                                     // MakerGen.cs:238
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",// MakerGen.cs:239
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",// MakerGen.cs:240
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
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:407
                // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:219
                // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                public ElementDefinitionInfo Element_WithdrawalPeriod;                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                        // MakerGen.cs:395
                        ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies"                                    // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_WithdrawalPeriod.Write(sDef);                                                                                   // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_TargetSpecies()                                                                                                 // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Code",                                                                                          // MakerGen.cs:238
                            Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",                                // MakerGen.cs:239
                            Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",                                 // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                        this.Element_WithdrawalPeriod = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_WithdrawalPeriod",                                                                              // MakerGen.cs:238
                            Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",                    // MakerGen.cs:239
                            Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new Type_WithdrawalPeriod                                                                                   // MakerGen.cs:262
                                {                                                                                                           // MakerGen.cs:263
                                }                                                                                                           // MakerGen.cs:264
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
            public ElementDefinitionInfo Element_FirstDose;                                                                                 // MakerGen.cs:219
            // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
            public ElementDefinitionInfo Element_MaxSingleDose;                                                                             // MakerGen.cs:219
            // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
            public ElementDefinitionInfo Element_MaxDosePerDay;                                                                             // MakerGen.cs:219
            // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
            public ElementDefinitionInfo Element_MaxDosePerTreatmentPeriod;                                                                 // MakerGen.cs:219
            // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
            public ElementDefinitionInfo Element_MaxTreatmentPeriod;                                                                        // MakerGen.cs:219
            // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
            public ElementDefinitionInfo Element_TargetSpecies;                                                                             // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MedicinalProductPharmaceutical.routeOfAdministration",                                                          // MakerGen.cs:395
                    ElementId = "MedicinalProductPharmaceutical.routeOfAdministration"                                                      // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_FirstDose.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_MaxSingleDose.Write(sDef);                                                                                          // MakerGen.cs:223
                Element_MaxDosePerDay.Write(sDef);                                                                                          // MakerGen.cs:223
                Element_MaxDosePerTreatmentPeriod.Write(sDef);                                                                              // MakerGen.cs:223
                Element_MaxTreatmentPeriod.Write(sDef);                                                                                     // MakerGen.cs:223
                Element_TargetSpecies.Write(sDef);                                                                                          // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_RouteOfAdministration()                                                                                             // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.code",                                                  // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.code",                                                   // MakerGen.cs:240
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
                    // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
                    this.Element_FirstDose = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_FirstDose",                                                                                         // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",                                             // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
                    this.Element_MaxSingleDose = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_MaxSingleDose",                                                                                     // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",                                         // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
                    this.Element_MaxDosePerDay = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_MaxDosePerDay",                                                                                     // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",                                         // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
                    this.Element_MaxDosePerTreatmentPeriod = new ElementDefinitionInfo                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_MaxDosePerTreatmentPeriod",                                                                         // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",                             // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
                    this.Element_MaxTreatmentPeriod = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_MaxTreatmentPeriod",                                                                                // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",                                    // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                    this.Element_TargetSpecies = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_TargetSpecies",                                                                                     // MakerGen.cs:238
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                         // MakerGen.cs:239
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_TargetSpecies                                                                                          // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. MedicinalProductPharmaceutical.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. MedicinalProductPharmaceutical.administrableDoseForm
        public ElementDefinitionInfo Element_AdministrableDoseForm;                                                                         // MakerGen.cs:219
        // 3. MedicinalProductPharmaceutical.unitOfPresentation
        public ElementDefinitionInfo Element_UnitOfPresentation;                                                                            // MakerGen.cs:219
        // 4. MedicinalProductPharmaceutical.ingredient
        public ElementDefinitionInfo Element_Ingredient;                                                                                    // MakerGen.cs:219
        // 5. MedicinalProductPharmaceutical.device
        public ElementDefinitionInfo Element_Device;                                                                                        // MakerGen.cs:219
        // 6. MedicinalProductPharmaceutical.characteristics
        public ElementDefinitionInfo Element_Characteristics;                                                                               // MakerGen.cs:219
        // 9. MedicinalProductPharmaceutical.routeOfAdministration
        public ElementDefinitionInfo Element_RouteOfAdministration;                                                                         // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MedicinalProductPharmaceutical",                                                                                    // MakerGen.cs:395
                ElementId = "MedicinalProductPharmaceutical"                                                                                // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_AdministrableDoseForm.Write(sDef);                                                                                      // MakerGen.cs:223
            Element_UnitOfPresentation.Write(sDef);                                                                                         // MakerGen.cs:223
            Element_Ingredient.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Device.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Characteristics.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_RouteOfAdministration.Write(sDef);                                                                                      // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MedicinalProductPharmaceutical()                                                                                    // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MedicinalProductPharmaceutical.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "MedicinalProductPharmaceutical.identifier",                                                                      // MakerGen.cs:239
                    Id = "MedicinalProductPharmaceutical.identifier",                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. MedicinalProductPharmaceutical.administrableDoseForm
                this.Element_AdministrableDoseForm = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AdministrableDoseForm",                                                                                 // MakerGen.cs:238
                    Path= "MedicinalProductPharmaceutical.administrableDoseForm",                                                           // MakerGen.cs:239
                    Id = "MedicinalProductPharmaceutical.administrableDoseForm",                                                            // MakerGen.cs:240
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
                // 3. MedicinalProductPharmaceutical.unitOfPresentation
                this.Element_UnitOfPresentation = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_UnitOfPresentation",                                                                                    // MakerGen.cs:238
                    Path= "MedicinalProductPharmaceutical.unitOfPresentation",                                                              // MakerGen.cs:239
                    Id = "MedicinalProductPharmaceutical.unitOfPresentation",                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
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
                // 4. MedicinalProductPharmaceutical.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Ingredient",                                                                                            // MakerGen.cs:238
                    Path= "MedicinalProductPharmaceutical.ingredient",                                                                      // MakerGen.cs:239
                    Id = "MedicinalProductPharmaceutical.ingredient",                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"                                        // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. MedicinalProductPharmaceutical.device
                this.Element_Device = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Device",                                                                                                // MakerGen.cs:238
                    Path= "MedicinalProductPharmaceutical.device",                                                                          // MakerGen.cs:239
                    Id = "MedicinalProductPharmaceutical.device",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. MedicinalProductPharmaceutical.characteristics
                this.Element_Characteristics = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Characteristics",                                                                                       // MakerGen.cs:238
                    Path= "MedicinalProductPharmaceutical.characteristics",                                                                 // MakerGen.cs:239
                    Id = "MedicinalProductPharmaceutical.characteristics",                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Characteristics                                                                                            // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. MedicinalProductPharmaceutical.routeOfAdministration
                this.Element_RouteOfAdministration = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_RouteOfAdministration",                                                                                 // MakerGen.cs:238
                    Path= "MedicinalProductPharmaceutical.routeOfAdministration",                                                           // MakerGen.cs:239
                    Id = "MedicinalProductPharmaceutical.routeOfAdministration",                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_RouteOfAdministration                                                                                      // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MedicinalProductPharmaceutical";                                                                                   // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical";                                            // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
