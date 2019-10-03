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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'MedicinalProductIndication'
    /// </summary>
    // 0. MedicinalProductIndication
    public partial class Resource_MedicinalProductIndication : FhirKhit.Maker.Common.Resource.Resource_DomainResource                       // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 7. MedicinalProductIndication.otherTherapy
        public partial class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
            public ElementDefinitionInfo Element_TherapyRelationshipType;                                                                   // MakerGen.cs:217
            // 9. MedicinalProductIndication.otherTherapy.medication[x]
            public ElementDefinitionInfo Element_Medication;                                                                                // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "MedicinalProductIndication.otherTherapy",                                                                       // MakerGen.cs:393
                    ElementId = "MedicinalProductIndication.otherTherapy"                                                                   // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_TherapyRelationshipType.Write(sDef);                                                                                // MakerGen.cs:221
                Element_Medication.Write(sDef);                                                                                             // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_OtherTherapy()                                                                                                      // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
                    this.Element_TherapyRelationshipType = new ElementDefinitionInfo                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_TherapyRelationshipType",                                                                           // MakerGen.cs:236
                        Path= "MedicinalProductIndication.otherTherapy.therapyRelationshipType",                                            // MakerGen.cs:237
                        Id = "MedicinalProductIndication.otherTherapy.therapyRelationshipType",                                             // MakerGen.cs:238
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
                    // 9. MedicinalProductIndication.otherTherapy.medication[x]
                    this.Element_Medication = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Medication",                                                                                        // MakerGen.cs:236
                        Path= "MedicinalProductIndication.otherTherapy.medication[x]",                                                      // MakerGen.cs:237
                        Id = "MedicinalProductIndication.otherTherapy.medication[x]",                                                       // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            },                                                                                                              // MakerGen.cs:320
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                             // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Substance",                                                    // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"                                        // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. MedicinalProductIndication.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:217
        // 2. MedicinalProductIndication.diseaseSymptomProcedure
        public ElementDefinitionInfo Element_DiseaseSymptomProcedure;                                                                       // MakerGen.cs:217
        // 3. MedicinalProductIndication.diseaseStatus
        public ElementDefinitionInfo Element_DiseaseStatus;                                                                                 // MakerGen.cs:217
        // 4. MedicinalProductIndication.comorbidity
        public ElementDefinitionInfo Element_Comorbidity;                                                                                   // MakerGen.cs:217
        // 5. MedicinalProductIndication.intendedEffect
        public ElementDefinitionInfo Element_IntendedEffect;                                                                                // MakerGen.cs:217
        // 6. MedicinalProductIndication.duration
        public ElementDefinitionInfo Element_Duration;                                                                                      // MakerGen.cs:217
        // 7. MedicinalProductIndication.otherTherapy
        public ElementDefinitionInfo Element_OtherTherapy;                                                                                  // MakerGen.cs:217
        // 10. MedicinalProductIndication.undesirableEffect
        public ElementDefinitionInfo Element_UndesirableEffect;                                                                             // MakerGen.cs:217
        // 11. MedicinalProductIndication.population
        public ElementDefinitionInfo Element_Population;                                                                                    // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "MedicinalProductIndication",                                                                                        // MakerGen.cs:393
                ElementId = "MedicinalProductIndication"                                                                                    // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_DiseaseSymptomProcedure.Write(sDef);                                                                                    // MakerGen.cs:221
            Element_DiseaseStatus.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_Comorbidity.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_IntendedEffect.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_Duration.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_OtherTherapy.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_UndesirableEffect.Write(sDef);                                                                                          // MakerGen.cs:221
            Element_Population.Write(sDef);                                                                                                 // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_MedicinalProductIndication()                                                                                        // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. MedicinalProductIndication.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:236
                    Path= "MedicinalProductIndication.subject",                                                                             // MakerGen.cs:237
                    Id = "MedicinalProductIndication.subject",                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                                 // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Medication"                                                        // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. MedicinalProductIndication.diseaseSymptomProcedure
                this.Element_DiseaseSymptomProcedure = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_DiseaseSymptomProcedure",                                                                               // MakerGen.cs:236
                    Path= "MedicinalProductIndication.diseaseSymptomProcedure",                                                             // MakerGen.cs:237
                    Id = "MedicinalProductIndication.diseaseSymptomProcedure",                                                              // MakerGen.cs:238
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
                // 3. MedicinalProductIndication.diseaseStatus
                this.Element_DiseaseStatus = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_DiseaseStatus",                                                                                         // MakerGen.cs:236
                    Path= "MedicinalProductIndication.diseaseStatus",                                                                       // MakerGen.cs:237
                    Id = "MedicinalProductIndication.diseaseStatus",                                                                        // MakerGen.cs:238
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
                // 4. MedicinalProductIndication.comorbidity
                this.Element_Comorbidity = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Comorbidity",                                                                                           // MakerGen.cs:236
                    Path= "MedicinalProductIndication.comorbidity",                                                                         // MakerGen.cs:237
                    Id = "MedicinalProductIndication.comorbidity",                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. MedicinalProductIndication.intendedEffect
                this.Element_IntendedEffect = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_IntendedEffect",                                                                                        // MakerGen.cs:236
                    Path= "MedicinalProductIndication.intendedEffect",                                                                      // MakerGen.cs:237
                    Id = "MedicinalProductIndication.intendedEffect",                                                                       // MakerGen.cs:238
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
                // 6. MedicinalProductIndication.duration
                this.Element_Duration = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Duration",                                                                                              // MakerGen.cs:236
                    Path= "MedicinalProductIndication.duration",                                                                            // MakerGen.cs:237
                    Id = "MedicinalProductIndication.duration",                                                                             // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. MedicinalProductIndication.otherTherapy
                this.Element_OtherTherapy = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_OtherTherapy",                                                                                          // MakerGen.cs:236
                    Path= "MedicinalProductIndication.otherTherapy",                                                                        // MakerGen.cs:237
                    Id = "MedicinalProductIndication.otherTherapy",                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_OtherTherapy                                                                                               // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. MedicinalProductIndication.undesirableEffect
                this.Element_UndesirableEffect = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_UndesirableEffect",                                                                                     // MakerGen.cs:236
                    Path= "MedicinalProductIndication.undesirableEffect",                                                                   // MakerGen.cs:237
                    Id = "MedicinalProductIndication.undesirableEffect",                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect"                                 // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. MedicinalProductIndication.population
                this.Element_Population = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Population",                                                                                            // MakerGen.cs:236
                    Path= "MedicinalProductIndication.population",                                                                          // MakerGen.cs:237
                    Id = "MedicinalProductIndication.population",                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Population                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "MedicinalProductIndication";                                                                                       // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication";                                                // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
