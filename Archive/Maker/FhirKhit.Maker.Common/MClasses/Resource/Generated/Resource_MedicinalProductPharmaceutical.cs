using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'MedicinalProductPharmaceutical'
    /// </summary>
    // 0. MedicinalProductPharmaceutical
    public partial class Resource_MedicinalProductPharmaceutical : FhirKhit.Maker.Common.Resource.Resource_DomainResource                   // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 6. MedicinalProductPharmaceutical.characteristics
        public partial class Type_Characteristics : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 7. MedicinalProductPharmaceutical.characteristics.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:217
            // 8. MedicinalProductPharmaceutical.characteristics.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "MedicinalProductPharmaceutical.characteristics",                                                                // MakerGen.cs:393
                    ElementId = "MedicinalProductPharmaceutical.characteristics"                                                            // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Characteristics()                                                                                                   // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 7. MedicinalProductPharmaceutical.characteristics.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Code",                                                                                              // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.characteristics.code",                                                        // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.characteristics.code",                                                         // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 8. MedicinalProductPharmaceutical.characteristics.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Status",                                                                                            // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.characteristics.status",                                                      // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.characteristics.status",                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 9. MedicinalProductPharmaceutical.routeOfAdministration
        public partial class Type_RouteOfAdministration : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
            public partial class Type_TargetSpecies : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                public partial class Type_WithdrawalPeriod : FhirKhit.Maker.Common.Complex.ComplexBase                                      // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                    public ElementDefinitionInfo Element_Tissue;                                                                            // MakerGen.cs:217
                    // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                    public ElementDefinitionInfo Element_Value;                                                                             // MakerGen.cs:217
                    // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                    public ElementDefinitionInfo Element_SupportingInformation;                                                             // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",                   // MakerGen.cs:393
                            ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod"               // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Tissue.Write(sDef);                                                                                         // MakerGen.cs:221
                        Element_Value.Write(sDef);                                                                                          // MakerGen.cs:221
                        Element_SupportingInformation.Write(sDef);                                                                          // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_WithdrawalPeriod()                                                                                          // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                            this.Element_Tissue = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Tissue",                                                                                    // MakerGen.cs:236
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",         // MakerGen.cs:237
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",          // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:316
                                    {                                                                                                       // MakerGen.cs:317
                                    }                                                                                                       // MakerGen.cs:320
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                            this.Element_Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Value",                                                                                     // MakerGen.cs:236
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",          // MakerGen.cs:237
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",           // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:356
                                    {                                                                                                       // MakerGen.cs:357
                                    }                                                                                                       // MakerGen.cs:358
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                            this.Element_SupportingInformation = new ElementDefinitionInfo                                                  // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_SupportingInformation",                                                                     // MakerGen.cs:236
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",// MakerGen.cs:237
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",// MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:217
                // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                public ElementDefinitionInfo Element_WithdrawalPeriod;                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                        // MakerGen.cs:393
                        ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies"                                    // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_WithdrawalPeriod.Write(sDef);                                                                                   // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_TargetSpecies()                                                                                                 // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Code",                                                                                          // MakerGen.cs:236
                            Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",                                // MakerGen.cs:237
                            Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",                                 // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                        this.Element_WithdrawalPeriod = new ElementDefinitionInfo                                                           // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_WithdrawalPeriod",                                                                              // MakerGen.cs:236
                            Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",                    // MakerGen.cs:237
                            Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",                     // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_WithdrawalPeriod                                                                                   // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:217
            // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
            public ElementDefinitionInfo Element_FirstDose;                                                                                 // MakerGen.cs:217
            // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
            public ElementDefinitionInfo Element_MaxSingleDose;                                                                             // MakerGen.cs:217
            // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
            public ElementDefinitionInfo Element_MaxDosePerDay;                                                                             // MakerGen.cs:217
            // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
            public ElementDefinitionInfo Element_MaxDosePerTreatmentPeriod;                                                                 // MakerGen.cs:217
            // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
            public ElementDefinitionInfo Element_MaxTreatmentPeriod;                                                                        // MakerGen.cs:217
            // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
            public ElementDefinitionInfo Element_TargetSpecies;                                                                             // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "MedicinalProductPharmaceutical.routeOfAdministration",                                                          // MakerGen.cs:393
                    ElementId = "MedicinalProductPharmaceutical.routeOfAdministration"                                                      // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_FirstDose.Write(sDef);                                                                                              // MakerGen.cs:221
                Element_MaxSingleDose.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_MaxDosePerDay.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_MaxDosePerTreatmentPeriod.Write(sDef);                                                                              // MakerGen.cs:221
                Element_MaxTreatmentPeriod.Write(sDef);                                                                                     // MakerGen.cs:221
                Element_TargetSpecies.Write(sDef);                                                                                          // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_RouteOfAdministration()                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Code",                                                                                              // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.code",                                                  // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.code",                                                   // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
                    this.Element_FirstDose = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_FirstDose",                                                                                         // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",                                             // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
                    this.Element_MaxSingleDose = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_MaxSingleDose",                                                                                     // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",                                         // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
                    this.Element_MaxDosePerDay = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_MaxDosePerDay",                                                                                     // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",                                         // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
                    this.Element_MaxDosePerTreatmentPeriod = new ElementDefinitionInfo                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_MaxDosePerTreatmentPeriod",                                                                         // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",                             // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                    // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
                    this.Element_MaxTreatmentPeriod = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_MaxTreatmentPeriod",                                                                                // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",                                    // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                                 // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                    this.Element_TargetSpecies = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_TargetSpecies",                                                                                     // MakerGen.cs:236
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                         // MakerGen.cs:237
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_TargetSpecies                                                                                          // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. MedicinalProductPharmaceutical.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. MedicinalProductPharmaceutical.administrableDoseForm
        public ElementDefinitionInfo Element_AdministrableDoseForm;                                                                         // MakerGen.cs:217
        // 3. MedicinalProductPharmaceutical.unitOfPresentation
        public ElementDefinitionInfo Element_UnitOfPresentation;                                                                            // MakerGen.cs:217
        // 4. MedicinalProductPharmaceutical.ingredient
        public ElementDefinitionInfo Element_Ingredient;                                                                                    // MakerGen.cs:217
        // 5. MedicinalProductPharmaceutical.device
        public ElementDefinitionInfo Element_Device;                                                                                        // MakerGen.cs:217
        // 6. MedicinalProductPharmaceutical.characteristics
        public ElementDefinitionInfo Element_Characteristics;                                                                               // MakerGen.cs:217
        // 9. MedicinalProductPharmaceutical.routeOfAdministration
        public ElementDefinitionInfo Element_RouteOfAdministration;                                                                         // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "MedicinalProductPharmaceutical",                                                                                    // MakerGen.cs:393
                ElementId = "MedicinalProductPharmaceutical"                                                                                // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_AdministrableDoseForm.Write(sDef);                                                                                      // MakerGen.cs:221
            Element_UnitOfPresentation.Write(sDef);                                                                                         // MakerGen.cs:221
            Element_Ingredient.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Device.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Characteristics.Write(sDef);                                                                                            // MakerGen.cs:221
            Element_RouteOfAdministration.Write(sDef);                                                                                      // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_MedicinalProductPharmaceutical()                                                                                    // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. MedicinalProductPharmaceutical.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "MedicinalProductPharmaceutical.identifier",                                                                      // MakerGen.cs:237
                    Id = "MedicinalProductPharmaceutical.identifier",                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. MedicinalProductPharmaceutical.administrableDoseForm
                this.Element_AdministrableDoseForm = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_AdministrableDoseForm",                                                                                 // MakerGen.cs:236
                    Path= "MedicinalProductPharmaceutical.administrableDoseForm",                                                           // MakerGen.cs:237
                    Id = "MedicinalProductPharmaceutical.administrableDoseForm",                                                            // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. MedicinalProductPharmaceutical.unitOfPresentation
                this.Element_UnitOfPresentation = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_UnitOfPresentation",                                                                                    // MakerGen.cs:236
                    Path= "MedicinalProductPharmaceutical.unitOfPresentation",                                                              // MakerGen.cs:237
                    Id = "MedicinalProductPharmaceutical.unitOfPresentation",                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. MedicinalProductPharmaceutical.ingredient
                this.Element_Ingredient = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Ingredient",                                                                                            // MakerGen.cs:236
                    Path= "MedicinalProductPharmaceutical.ingredient",                                                                      // MakerGen.cs:237
                    Id = "MedicinalProductPharmaceutical.ingredient",                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"                                        // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. MedicinalProductPharmaceutical.device
                this.Element_Device = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Device",                                                                                                // MakerGen.cs:236
                    Path= "MedicinalProductPharmaceutical.device",                                                                          // MakerGen.cs:237
                    Id = "MedicinalProductPharmaceutical.device",                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                                  // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. MedicinalProductPharmaceutical.characteristics
                this.Element_Characteristics = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Characteristics",                                                                                       // MakerGen.cs:236
                    Path= "MedicinalProductPharmaceutical.characteristics",                                                                 // MakerGen.cs:237
                    Id = "MedicinalProductPharmaceutical.characteristics",                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Characteristics                                                                                            // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. MedicinalProductPharmaceutical.routeOfAdministration
                this.Element_RouteOfAdministration = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_RouteOfAdministration",                                                                                 // MakerGen.cs:236
                    Path= "MedicinalProductPharmaceutical.routeOfAdministration",                                                           // MakerGen.cs:237
                    Id = "MedicinalProductPharmaceutical.routeOfAdministration",                                                            // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_RouteOfAdministration                                                                                      // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "MedicinalProductPharmaceutical";                                                                                   // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical";                                            // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
