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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'MedicinalProductPharmaceutical'
    /// </summary>
    // 0. MedicinalProductPharmaceutical
    public class Resource_MedicinalProductPharmaceutical : FhirKhit.Maker.Common.Resource.ResourceBase                                      // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_MedicinalProductPharmaceutical_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                         // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 6. MedicinalProductPharmaceutical.characteristics
            public class Type_Characteristics : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Characteristics_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 7. MedicinalProductPharmaceutical.characteristics.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:211
                    // 8. MedicinalProductPharmaceutical.characteristics.status
                    public ElementDefinitionInfo Element_Status;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Characteristics_Elements()                                                                                  // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. MedicinalProductPharmaceutical.characteristics.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Code",                                                                                      // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.characteristics.code",                                                // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.characteristics.code",                                                 // MakerGen.cs:232
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
                            // 8. MedicinalProductPharmaceutical.characteristics.status
                            this.Element_Status = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Status",                                                                                    // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.characteristics.status",                                              // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.characteristics.status",                                               // MakerGen.cs:232
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Status.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Characteristics_Elements Elements                                                                               // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Characteristics_Elements();                                                            // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Characteristics_Elements elements;                                                                                     // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Characteristics()                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MedicinalProductPharmaceutical.characteristics",                                                            // MakerGen.cs:420
                        ElementId = "MedicinalProductPharmaceutical.characteristics"                                                        // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 9. MedicinalProductPharmaceutical.routeOfAdministration
            public class Type_RouteOfAdministration : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_RouteOfAdministration_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                    public class Type_TargetSpecies : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_TargetSpecies_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                            public class Type_WithdrawalPeriod : FhirKhit.Maker.Common.Complex.ComplexBase                                  // MakerGen.cs:376
                            {                                                                                                               // MakerGen.cs:377
                                public class Type_WithdrawalPeriod_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                   // MakerGen.cs:378
                                {                                                                                                           // MakerGen.cs:379
                                    // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                                    public ElementDefinitionInfo Element_Tissue;                                                            // MakerGen.cs:211
                                    // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                                    public ElementDefinitionInfo Element_Value;                                                             // MakerGen.cs:211
                                    // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                                    public ElementDefinitionInfo Element_SupportingInformation;                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                                    public Type_WithdrawalPeriod_Elements()                                                                 // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:226
                                            // 19. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue
                                            this.Element_Tissue = new ElementDefinitionInfo                                                 // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Tissue",                                                                    // MakerGen.cs:230
                                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",// MakerGen.cs:231
                                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.tissue",// MakerGen.cs:232
                                                Min = 1,                                                                                    // MakerGen.cs:233
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
                                            // 20. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value
                                            this.Element_Value = new ElementDefinitionInfo                                                  // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Value",                                                                     // MakerGen.cs:230
                                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",// MakerGen.cs:231
                                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.value",// MakerGen.cs:232
                                                Min = 1,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                         // MakerGen.cs:350
                                                    {                                                                                       // MakerGen.cs:351
                                                    }                                                                                       // MakerGen.cs:352
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 21. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation
                                            this.Element_SupportingInformation = new ElementDefinitionInfo                                  // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_SupportingInformation",                                                     // MakerGen.cs:230
                                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",// MakerGen.cs:231
                                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod.supportingInformation",// MakerGen.cs:232
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
                                    }                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:390
                                    {                                                                                                       // MakerGen.cs:391
                                        base.Write(sDef);                                                                                   // MakerGen.cs:392
                                        Element_Tissue.Write(sDef);                                                                         // MakerGen.cs:215
                                        Element_Value.Write(sDef);                                                                          // MakerGen.cs:215
                                        Element_SupportingInformation.Write(sDef);                                                          // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:394
                                }                                                                                                           // MakerGen.cs:396
                                public Type_WithdrawalPeriod_Elements Elements                                                              // MakerGen.cs:398
                                {                                                                                                           // MakerGen.cs:399
                                    get                                                                                                     // MakerGen.cs:400
                                    {                                                                                                       // MakerGen.cs:401
                                        if (this.elements == null)                                                                          // MakerGen.cs:402
                                            this.elements = new Type_WithdrawalPeriod_Elements();                                           // MakerGen.cs:403
                                        return this.elements;                                                                               // MakerGen.cs:404
                                    }                                                                                                       // MakerGen.cs:405
                                }                                                                                                           // MakerGen.cs:406
                                Type_WithdrawalPeriod_Elements elements;                                                                    // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                                public Type_WithdrawalPeriod()                                                                              // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:411
                                }                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:416
                                {                                                                                                           // MakerGen.cs:417
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:418
                                    {                                                                                                       // MakerGen.cs:419
                                        Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",       // MakerGen.cs:420
                                        ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod"   // MakerGen.cs:421
                                    });                                                                                                     // MakerGen.cs:422
                                    if (this.elements != null)                                                                              // MakerGen.cs:423
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:424
                                }                                                                                                           // MakerGen.cs:425
                            }                                                                                                               // MakerGen.cs:426
                            // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                            public ElementDefinitionInfo Element_Code;                                                                      // MakerGen.cs:211
                            // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                            public ElementDefinitionInfo Element_WithdrawalPeriod;                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_TargetSpecies_Elements()                                                                            // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 17. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code
                                    this.Element_Code = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Code",                                                                              // MakerGen.cs:230
                                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",                    // MakerGen.cs:231
                                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.code",                     // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 18. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod
                                    this.Element_WithdrawalPeriod = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_WithdrawalPeriod",                                                                  // MakerGen.cs:230
                                        Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",        // MakerGen.cs:231
                                        Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod",         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_WithdrawalPeriod                                                                       // MakerGen.cs:254
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
                                Element_Code.Write(sDef);                                                                                   // MakerGen.cs:215
                                Element_WithdrawalPeriod.Write(sDef);                                                                       // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_TargetSpecies_Elements Elements                                                                         // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_TargetSpecies_Elements();                                                      // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_TargetSpecies_Elements elements;                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_TargetSpecies()                                                                                         // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                // MakerGen.cs:420
                                ElementId = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies"                            // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:211
                    // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
                    public ElementDefinitionInfo Element_FirstDose;                                                                         // MakerGen.cs:211
                    // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
                    public ElementDefinitionInfo Element_MaxSingleDose;                                                                     // MakerGen.cs:211
                    // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
                    public ElementDefinitionInfo Element_MaxDosePerDay;                                                                     // MakerGen.cs:211
                    // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
                    public ElementDefinitionInfo Element_MaxDosePerTreatmentPeriod;                                                         // MakerGen.cs:211
                    // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
                    public ElementDefinitionInfo Element_MaxTreatmentPeriod;                                                                // MakerGen.cs:211
                    // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                    public ElementDefinitionInfo Element_TargetSpecies;                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_RouteOfAdministration_Elements()                                                                            // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. MedicinalProductPharmaceutical.routeOfAdministration.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Code",                                                                                      // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.code",                                          // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.code",                                           // MakerGen.cs:232
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
                            // 11. MedicinalProductPharmaceutical.routeOfAdministration.firstDose
                            this.Element_FirstDose = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_FirstDose",                                                                                 // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",                                     // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.firstDose",                                      // MakerGen.cs:232
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
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose
                            this.Element_MaxSingleDose = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_MaxSingleDose",                                                                             // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",                                 // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxSingleDose",                                  // MakerGen.cs:232
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
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay
                            this.Element_MaxDosePerDay = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_MaxDosePerDay",                                                                             // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",                                 // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerDay",                                  // MakerGen.cs:232
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
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod
                            this.Element_MaxDosePerTreatmentPeriod = new ElementDefinitionInfo                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_MaxDosePerTreatmentPeriod",                                                                 // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",                     // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxDosePerTreatmentPeriod",                      // MakerGen.cs:232
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
                            // 15. MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod
                            this.Element_MaxTreatmentPeriod = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_MaxTreatmentPeriod",                                                                        // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",                            // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.maxTreatmentPeriod",                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Duration                                                         // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies
                            this.Element_TargetSpecies = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_TargetSpecies",                                                                             // MakerGen.cs:230
                                Path= "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                 // MakerGen.cs:231
                                Id = "MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies",                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_TargetSpecies                                                                                  // MakerGen.cs:254
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
                        Element_FirstDose.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_MaxSingleDose.Write(sDef);                                                                                  // MakerGen.cs:215
                        Element_MaxDosePerDay.Write(sDef);                                                                                  // MakerGen.cs:215
                        Element_MaxDosePerTreatmentPeriod.Write(sDef);                                                                      // MakerGen.cs:215
                        Element_MaxTreatmentPeriod.Write(sDef);                                                                             // MakerGen.cs:215
                        Element_TargetSpecies.Write(sDef);                                                                                  // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_RouteOfAdministration_Elements Elements                                                                         // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_RouteOfAdministration_Elements();                                                      // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_RouteOfAdministration_Elements elements;                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_RouteOfAdministration()                                                                                         // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MedicinalProductPharmaceutical.routeOfAdministration",                                                      // MakerGen.cs:420
                        ElementId = "MedicinalProductPharmaceutical.routeOfAdministration"                                                  // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. MedicinalProductPharmaceutical.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. MedicinalProductPharmaceutical.administrableDoseForm
            public ElementDefinitionInfo Element_AdministrableDoseForm;                                                                     // MakerGen.cs:211
            // 3. MedicinalProductPharmaceutical.unitOfPresentation
            public ElementDefinitionInfo Element_UnitOfPresentation;                                                                        // MakerGen.cs:211
            // 4. MedicinalProductPharmaceutical.ingredient
            public ElementDefinitionInfo Element_Ingredient;                                                                                // MakerGen.cs:211
            // 5. MedicinalProductPharmaceutical.device
            public ElementDefinitionInfo Element_Device;                                                                                    // MakerGen.cs:211
            // 6. MedicinalProductPharmaceutical.characteristics
            public ElementDefinitionInfo Element_Characteristics;                                                                           // MakerGen.cs:211
            // 9. MedicinalProductPharmaceutical.routeOfAdministration
            public ElementDefinitionInfo Element_RouteOfAdministration;                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_MedicinalProductPharmaceutical_Elements()                                                                       // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. MedicinalProductPharmaceutical.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "MedicinalProductPharmaceutical.identifier",                                                                  // MakerGen.cs:231
                        Id = "MedicinalProductPharmaceutical.identifier",                                                                   // MakerGen.cs:232
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
                    // 2. MedicinalProductPharmaceutical.administrableDoseForm
                    this.Element_AdministrableDoseForm = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_AdministrableDoseForm",                                                                             // MakerGen.cs:230
                        Path= "MedicinalProductPharmaceutical.administrableDoseForm",                                                       // MakerGen.cs:231
                        Id = "MedicinalProductPharmaceutical.administrableDoseForm",                                                        // MakerGen.cs:232
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
                    // 3. MedicinalProductPharmaceutical.unitOfPresentation
                    this.Element_UnitOfPresentation = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_UnitOfPresentation",                                                                                // MakerGen.cs:230
                        Path= "MedicinalProductPharmaceutical.unitOfPresentation",                                                          // MakerGen.cs:231
                        Id = "MedicinalProductPharmaceutical.unitOfPresentation",                                                           // MakerGen.cs:232
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
                    // 4. MedicinalProductPharmaceutical.ingredient
                    this.Element_Ingredient = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Ingredient",                                                                                        // MakerGen.cs:230
                        Path= "MedicinalProductPharmaceutical.ingredient",                                                                  // MakerGen.cs:231
                        Id = "MedicinalProductPharmaceutical.ingredient",                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient"                                    // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. MedicinalProductPharmaceutical.device
                    this.Element_Device = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Device",                                                                                            // MakerGen.cs:230
                        Path= "MedicinalProductPharmaceutical.device",                                                                      // MakerGen.cs:231
                        Id = "MedicinalProductPharmaceutical.device",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                              // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. MedicinalProductPharmaceutical.characteristics
                    this.Element_Characteristics = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Characteristics",                                                                                   // MakerGen.cs:230
                        Path= "MedicinalProductPharmaceutical.characteristics",                                                             // MakerGen.cs:231
                        Id = "MedicinalProductPharmaceutical.characteristics",                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Characteristics                                                                                        // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. MedicinalProductPharmaceutical.routeOfAdministration
                    this.Element_RouteOfAdministration = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_RouteOfAdministration",                                                                             // MakerGen.cs:230
                        Path= "MedicinalProductPharmaceutical.routeOfAdministration",                                                       // MakerGen.cs:231
                        Id = "MedicinalProductPharmaceutical.routeOfAdministration",                                                        // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_RouteOfAdministration                                                                                  // MakerGen.cs:254
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
                Element_AdministrableDoseForm.Write(sDef);                                                                                  // MakerGen.cs:215
                Element_UnitOfPresentation.Write(sDef);                                                                                     // MakerGen.cs:215
                Element_Ingredient.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Device.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Characteristics.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_RouteOfAdministration.Write(sDef);                                                                                  // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_MedicinalProductPharmaceutical_Elements Elements                                                                    // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_MedicinalProductPharmaceutical_Elements();                                                 // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_MedicinalProductPharmaceutical_Elements elements;                                                                          // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_MedicinalProductPharmaceutical()                                                                                    // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "MedicinalProductPharmaceutical";                                                                                   // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical";                                            // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "MedicinalProductPharmaceutical",                                                                                    // MakerGen.cs:420
                ElementId = "MedicinalProductPharmaceutical"                                                                                // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
