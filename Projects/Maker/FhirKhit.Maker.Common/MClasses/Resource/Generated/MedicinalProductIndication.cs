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
      "id": "MedicinalProductIndication",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication",
      "version": "4.0.0",
      "name": "MedicinalProductIndication",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Indication for the Medicinal Product.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductIndication",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductIndication",
            "path": "MedicinalProductIndication",
            "short": "MedicinalProductIndication",
            "definition": "Indication for the Medicinal Product.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductIndication.subject",
            "path": "MedicinalProductIndication.subject",
            "short": "The medication for which this is an indication",
            "definition": "The medication for which this is an indication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/Medication"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.diseaseSymptomProcedure",
            "path": "MedicinalProductIndication.diseaseSymptomProcedure",
            "short": "The disease, symptom or procedure that is the indication for treatment",
            "definition": "The disease, symptom or procedure that is the indication for treatment.",
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
            "id": "MedicinalProductIndication.diseaseStatus",
            "path": "MedicinalProductIndication.diseaseStatus",
            "short": "The status of the disease or symptom for which the indication applies",
            "definition": "The status of the disease or symptom for which the indication applies.",
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
            "id": "MedicinalProductIndication.comorbidity",
            "path": "MedicinalProductIndication.comorbidity",
            "short": "Comorbidity (concurrent condition) or co-infection as part of the indication",
            "definition": "Comorbidity (concurrent condition) or co-infection as part of the indication.",
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
            "id": "MedicinalProductIndication.intendedEffect",
            "path": "MedicinalProductIndication.intendedEffect",
            "short": "The intended effect, aim or strategy to be achieved by the indication",
            "definition": "The intended effect, aim or strategy to be achieved by the indication.",
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
            "id": "MedicinalProductIndication.duration",
            "path": "MedicinalProductIndication.duration",
            "short": "Timing or duration information as part of the indication",
            "definition": "Timing or duration information as part of the indication.",
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
            "id": "MedicinalProductIndication.otherTherapy",
            "path": "MedicinalProductIndication.otherTherapy",
            "short": "Information about the use of the medicinal product in relation to other therapies described as part of the indication",
            "definition": "Information about the use of the medicinal product in relation to other therapies described as part of the indication.",
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
            "id": "MedicinalProductIndication.otherTherapy.therapyRelationshipType",
            "path": "MedicinalProductIndication.otherTherapy.therapyRelationshipType",
            "short": "The type of relationship between the medicinal product indication or contraindication and another therapy",
            "definition": "The type of relationship between the medicinal product indication or contraindication and another therapy.",
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
            "id": "MedicinalProductIndication.otherTherapy.medication[x]",
            "path": "MedicinalProductIndication.otherTherapy.medication[x]",
            "short": "Reference to a specific medication (active substance, medicinal product or class of products) as part of an indication or contraindication",
            "definition": "Reference to a specific medication (active substance, medicinal product or class of products) as part of an indication or contraindication.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.undesirableEffect",
            "path": "MedicinalProductIndication.undesirableEffect",
            "short": "Describe the undesirable effects of the medicinal product",
            "definition": "Describe the undesirable effects of the medicinal product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductIndication.population",
            "path": "MedicinalProductIndication.population",
            "short": "The population group to which this applies",
            "definition": "The population group to which this applies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Population"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'MedicinalProductIndication'
    /// </summary>
    // 0. MedicinalProductIndication
    public class MedicinalProductIndication : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class MedicinalProductIndication_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 7. MedicinalProductIndication.otherTherapy
            public class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_OtherTherapy_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
                    public ElementDefinitionInfo TherapyRelationshipType;                                                                   // MakerGen.cs:216
                    // 9. MedicinalProductIndication.otherTherapy.medication[x]
                    public ElementDefinitionInfo Medication;                                                                                // MakerGen.cs:216
                    public Type_OtherTherapy_Elements()                                                                                     // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
                            this.TherapyRelationshipType = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "TherapyRelationshipType",                                                                           // MakerGen.cs:235
                                Path= "MedicinalProductIndication.otherTherapy.therapyRelationshipType",                                    // MakerGen.cs:236
                                Id = "MedicinalProductIndication.otherTherapy.therapyRelationshipType",                                     // MakerGen.cs:237
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
                            // 9. MedicinalProductIndication.otherTherapy.medication[x]
                            this.Medication = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Medication",                                                                                        // MakerGen.cs:235
                                Path= "MedicinalProductIndication.otherTherapy.medication[x]",                                              // MakerGen.cs:236
                                Id = "MedicinalProductIndication.otherTherapy.medication[x]",                                               // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    },                                                                                                      // MakerGen.cs:319
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Medication",                                           // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Substance",                                            // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"                                // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        TherapyRelationshipType.Write(sDef);                                                                                // MakerGen.cs:220
                        Medication.Write(sDef);                                                                                             // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_OtherTherapy_Elements Elements { get; }                                                                         // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_OtherTherapy()                                                                                                  // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_OtherTherapy_Elements();                                                                       // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. MedicinalProductIndication.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 2. MedicinalProductIndication.diseaseSymptomProcedure
            public ElementDefinitionInfo DiseaseSymptomProcedure;                                                                           // MakerGen.cs:216
            // 3. MedicinalProductIndication.diseaseStatus
            public ElementDefinitionInfo DiseaseStatus;                                                                                     // MakerGen.cs:216
            // 4. MedicinalProductIndication.comorbidity
            public ElementDefinitionInfo Comorbidity;                                                                                       // MakerGen.cs:216
            // 5. MedicinalProductIndication.intendedEffect
            public ElementDefinitionInfo IntendedEffect;                                                                                    // MakerGen.cs:216
            // 6. MedicinalProductIndication.duration
            public ElementDefinitionInfo Duration;                                                                                          // MakerGen.cs:216
            // 7. MedicinalProductIndication.otherTherapy
            public ElementDefinitionInfo OtherTherapy;                                                                                      // MakerGen.cs:216
            // 10. MedicinalProductIndication.undesirableEffect
            public ElementDefinitionInfo UndesirableEffect;                                                                                 // MakerGen.cs:216
            // 11. MedicinalProductIndication.population
            public ElementDefinitionInfo Population;                                                                                        // MakerGen.cs:216
            public MedicinalProductIndication_Elements()                                                                                    // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicinalProductIndication.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "MedicinalProductIndication.subject",                                                                         // MakerGen.cs:236
                        Id = "MedicinalProductIndication.subject",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Medication"                                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MedicinalProductIndication.diseaseSymptomProcedure
                    this.DiseaseSymptomProcedure = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DiseaseSymptomProcedure",                                                                                   // MakerGen.cs:235
                        Path= "MedicinalProductIndication.diseaseSymptomProcedure",                                                         // MakerGen.cs:236
                        Id = "MedicinalProductIndication.diseaseSymptomProcedure",                                                          // MakerGen.cs:237
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
                    // 3. MedicinalProductIndication.diseaseStatus
                    this.DiseaseStatus = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DiseaseStatus",                                                                                             // MakerGen.cs:235
                        Path= "MedicinalProductIndication.diseaseStatus",                                                                   // MakerGen.cs:236
                        Id = "MedicinalProductIndication.diseaseStatus",                                                                    // MakerGen.cs:237
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
                    // 4. MedicinalProductIndication.comorbidity
                    this.Comorbidity = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Comorbidity",                                                                                               // MakerGen.cs:235
                        Path= "MedicinalProductIndication.comorbidity",                                                                     // MakerGen.cs:236
                        Id = "MedicinalProductIndication.comorbidity",                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. MedicinalProductIndication.intendedEffect
                    this.IntendedEffect = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "IntendedEffect",                                                                                            // MakerGen.cs:235
                        Path= "MedicinalProductIndication.intendedEffect",                                                                  // MakerGen.cs:236
                        Id = "MedicinalProductIndication.intendedEffect",                                                                   // MakerGen.cs:237
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
                    // 6. MedicinalProductIndication.duration
                    this.Duration = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Duration",                                                                                                  // MakerGen.cs:235
                        Path= "MedicinalProductIndication.duration",                                                                        // MakerGen.cs:236
                        Id = "MedicinalProductIndication.duration",                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. MedicinalProductIndication.otherTherapy
                    this.OtherTherapy = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OtherTherapy",                                                                                              // MakerGen.cs:235
                        Path= "MedicinalProductIndication.otherTherapy",                                                                    // MakerGen.cs:236
                        Id = "MedicinalProductIndication.otherTherapy",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_OtherTherapy                                                                                           // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. MedicinalProductIndication.undesirableEffect
                    this.UndesirableEffect = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UndesirableEffect",                                                                                         // MakerGen.cs:235
                        Path= "MedicinalProductIndication.undesirableEffect",                                                               // MakerGen.cs:236
                        Id = "MedicinalProductIndication.undesirableEffect",                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect"                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. MedicinalProductIndication.population
                    this.Population = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Population",                                                                                                // MakerGen.cs:235
                        Path= "MedicinalProductIndication.population",                                                                      // MakerGen.cs:236
                        Id = "MedicinalProductIndication.population",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Population                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                DiseaseSymptomProcedure.Write(sDef);                                                                                        // MakerGen.cs:220
                DiseaseStatus.Write(sDef);                                                                                                  // MakerGen.cs:220
                Comorbidity.Write(sDef);                                                                                                    // MakerGen.cs:220
                IntendedEffect.Write(sDef);                                                                                                 // MakerGen.cs:220
                Duration.Write(sDef);                                                                                                       // MakerGen.cs:220
                OtherTherapy.Write(sDef);                                                                                                   // MakerGen.cs:220
                UndesirableEffect.Write(sDef);                                                                                              // MakerGen.cs:220
                Population.Write(sDef);                                                                                                     // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public MedicinalProductIndication_Elements Elements { get; }                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public MedicinalProductIndication()                                                                                                 // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new MedicinalProductIndication_Elements();                                                                      // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
