using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'MedicinalProductIndication'
    /// </summary>
    // 0. MedicinalProductIndication
    public class MedicinalProductIndication : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class MedicinalProductIndication_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 7. MedicinalProductIndication.otherTherapy
            public class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_OtherTherapy_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
                    public ElementDefinitionInfo TherapyRelationshipType;                                                                   // MakerGen.cs:236
                    // 9. MedicinalProductIndication.otherTherapy.medication[x]
                    public ElementDefinitionInfo Medication;                                                                                // MakerGen.cs:236
                    public Type_OtherTherapy_Elements()                                                                                     // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
                            this.TherapyRelationshipType = new ElementDefinitionInfo                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "TherapyRelationshipType",                                                                           // MakerGen.cs:255
                                Path= "MedicinalProductIndication.otherTherapy.therapyRelationshipType",                                    // MakerGen.cs:256
                                Id = "MedicinalProductIndication.otherTherapy.therapyRelationshipType",                                     // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. MedicinalProductIndication.otherTherapy.medication[x]
                            this.Medication = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Medication",                                                                                        // MakerGen.cs:255
                                Path= "MedicinalProductIndication.otherTherapy.medication[x]",                                              // MakerGen.cs:256
                                Id = "MedicinalProductIndication.otherTherapy.medication[x]",                                               // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                     // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Medication",                                           // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Substance",                                            // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"                                // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        TherapyRelationshipType.Write(sDef);                                                                                // MakerGen.cs:240
                        Medication.Write(sDef);                                                                                             // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_OtherTherapy_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_OtherTherapy()                                                                                                  // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_OtherTherapy_Elements();                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. MedicinalProductIndication.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 2. MedicinalProductIndication.diseaseSymptomProcedure
            public ElementDefinitionInfo DiseaseSymptomProcedure;                                                                           // MakerGen.cs:236
            // 3. MedicinalProductIndication.diseaseStatus
            public ElementDefinitionInfo DiseaseStatus;                                                                                     // MakerGen.cs:236
            // 4. MedicinalProductIndication.comorbidity
            public ElementDefinitionInfo Comorbidity;                                                                                       // MakerGen.cs:236
            // 5. MedicinalProductIndication.intendedEffect
            public ElementDefinitionInfo IntendedEffect;                                                                                    // MakerGen.cs:236
            // 6. MedicinalProductIndication.duration
            public ElementDefinitionInfo Duration;                                                                                          // MakerGen.cs:236
            // 10. MedicinalProductIndication.undesirableEffect
            public ElementDefinitionInfo UndesirableEffect;                                                                                 // MakerGen.cs:236
            // 11. MedicinalProductIndication.population
            public ElementDefinitionInfo Population;                                                                                        // MakerGen.cs:236
            public MedicinalProductIndication_Elements()                                                                                    // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. MedicinalProductIndication.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "MedicinalProductIndication.subject",                                                                         // MakerGen.cs:256
                        Id = "MedicinalProductIndication.subject",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Medication"                                                    // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. MedicinalProductIndication.diseaseSymptomProcedure
                    this.DiseaseSymptomProcedure = new ElementDefinitionInfo                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DiseaseSymptomProcedure",                                                                                   // MakerGen.cs:255
                        Path= "MedicinalProductIndication.diseaseSymptomProcedure",                                                         // MakerGen.cs:256
                        Id = "MedicinalProductIndication.diseaseSymptomProcedure",                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. MedicinalProductIndication.diseaseStatus
                    this.DiseaseStatus = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DiseaseStatus",                                                                                             // MakerGen.cs:255
                        Path= "MedicinalProductIndication.diseaseStatus",                                                                   // MakerGen.cs:256
                        Id = "MedicinalProductIndication.diseaseStatus",                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. MedicinalProductIndication.comorbidity
                    this.Comorbidity = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Comorbidity",                                                                                               // MakerGen.cs:255
                        Path= "MedicinalProductIndication.comorbidity",                                                                     // MakerGen.cs:256
                        Id = "MedicinalProductIndication.comorbidity",                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. MedicinalProductIndication.intendedEffect
                    this.IntendedEffect = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "IntendedEffect",                                                                                            // MakerGen.cs:255
                        Path= "MedicinalProductIndication.intendedEffect",                                                                  // MakerGen.cs:256
                        Id = "MedicinalProductIndication.intendedEffect",                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. MedicinalProductIndication.duration
                    this.Duration = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Duration",                                                                                                  // MakerGen.cs:255
                        Path= "MedicinalProductIndication.duration",                                                                        // MakerGen.cs:256
                        Id = "MedicinalProductIndication.duration",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. MedicinalProductIndication.undesirableEffect
                    this.UndesirableEffect = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "UndesirableEffect",                                                                                         // MakerGen.cs:255
                        Path= "MedicinalProductIndication.undesirableEffect",                                                               // MakerGen.cs:256
                        Id = "MedicinalProductIndication.undesirableEffect",                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect"                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. MedicinalProductIndication.population
                    this.Population = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Population",                                                                                                // MakerGen.cs:255
                        Path= "MedicinalProductIndication.population",                                                                      // MakerGen.cs:256
                        Id = "MedicinalProductIndication.population",                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Population                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                DiseaseSymptomProcedure.Write(sDef);                                                                                        // MakerGen.cs:240
                DiseaseStatus.Write(sDef);                                                                                                  // MakerGen.cs:240
                Comorbidity.Write(sDef);                                                                                                    // MakerGen.cs:240
                IntendedEffect.Write(sDef);                                                                                                 // MakerGen.cs:240
                Duration.Write(sDef);                                                                                                       // MakerGen.cs:240
                UndesirableEffect.Write(sDef);                                                                                              // MakerGen.cs:240
                Population.Write(sDef);                                                                                                     // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public MedicinalProductIndication_Elements Elements { get; }                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public MedicinalProductIndication()                                                                                                 // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new MedicinalProductIndication_Elements();                                                                      // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
