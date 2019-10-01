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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'MedicinalProductIndication'
    /// </summary>
    // 0. MedicinalProductIndication
    public class Resource_MedicinalProductIndication : FhirKhit.Maker.Common.Resource.ResourceBase                                          // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 7. MedicinalProductIndication.otherTherapy
        public class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
            public ElementDefinitionInfo Element_TherapyRelationshipType;                                                                   // MakerGen.cs:212
            // 9. MedicinalProductIndication.otherTherapy.medication[x]
            public ElementDefinitionInfo Element_Medication;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicinalProductIndication.otherTherapy",                                                                       // MakerGen.cs:388
                    ElementId = "MedicinalProductIndication.otherTherapy"                                                                   // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_TherapyRelationshipType.Write(sDef);                                                                                // MakerGen.cs:216
                Element_Medication.Write(sDef);                                                                                             // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_OtherTherapy()                                                                                                      // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 8. MedicinalProductIndication.otherTherapy.therapyRelationshipType
                    this.Element_TherapyRelationshipType = new ElementDefinitionInfo                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_TherapyRelationshipType",                                                                           // MakerGen.cs:231
                        Path= "MedicinalProductIndication.otherTherapy.therapyRelationshipType",                                            // MakerGen.cs:232
                        Id = "MedicinalProductIndication.otherTherapy.therapyRelationshipType",                                             // MakerGen.cs:233
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
                    // 9. MedicinalProductIndication.otherTherapy.medication[x]
                    this.Element_Medication = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Medication",                                                                                        // MakerGen.cs:231
                        Path= "MedicinalProductIndication.otherTherapy.medication[x]",                                                      // MakerGen.cs:232
                        Id = "MedicinalProductIndication.otherTherapy.medication[x]",                                                       // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            },                                                                                                              // MakerGen.cs:315
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                             // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Substance",                                                    // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"                                        // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. MedicinalProductIndication.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 2. MedicinalProductIndication.diseaseSymptomProcedure
        public ElementDefinitionInfo Element_DiseaseSymptomProcedure;                                                                       // MakerGen.cs:212
        // 3. MedicinalProductIndication.diseaseStatus
        public ElementDefinitionInfo Element_DiseaseStatus;                                                                                 // MakerGen.cs:212
        // 4. MedicinalProductIndication.comorbidity
        public ElementDefinitionInfo Element_Comorbidity;                                                                                   // MakerGen.cs:212
        // 5. MedicinalProductIndication.intendedEffect
        public ElementDefinitionInfo Element_IntendedEffect;                                                                                // MakerGen.cs:212
        // 6. MedicinalProductIndication.duration
        public ElementDefinitionInfo Element_Duration;                                                                                      // MakerGen.cs:212
        // 7. MedicinalProductIndication.otherTherapy
        public ElementDefinitionInfo Element_OtherTherapy;                                                                                  // MakerGen.cs:212
        // 10. MedicinalProductIndication.undesirableEffect
        public ElementDefinitionInfo Element_UndesirableEffect;                                                                             // MakerGen.cs:212
        // 11. MedicinalProductIndication.population
        public ElementDefinitionInfo Element_Population;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "MedicinalProductIndication",                                                                                        // MakerGen.cs:388
                ElementId = "MedicinalProductIndication"                                                                                    // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_DiseaseSymptomProcedure.Write(sDef);                                                                                    // MakerGen.cs:216
            Element_DiseaseStatus.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_Comorbidity.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_IntendedEffect.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_Duration.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_OtherTherapy.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_UndesirableEffect.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_Population.Write(sDef);                                                                                                 // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_MedicinalProductIndication()                                                                                        // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. MedicinalProductIndication.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "MedicinalProductIndication.subject",                                                                             // MakerGen.cs:232
                    Id = "MedicinalProductIndication.subject",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Medication"                                                        // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. MedicinalProductIndication.diseaseSymptomProcedure
                this.Element_DiseaseSymptomProcedure = new ElementDefinitionInfo                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DiseaseSymptomProcedure",                                                                               // MakerGen.cs:231
                    Path= "MedicinalProductIndication.diseaseSymptomProcedure",                                                             // MakerGen.cs:232
                    Id = "MedicinalProductIndication.diseaseSymptomProcedure",                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
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
                // 3. MedicinalProductIndication.diseaseStatus
                this.Element_DiseaseStatus = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DiseaseStatus",                                                                                         // MakerGen.cs:231
                    Path= "MedicinalProductIndication.diseaseStatus",                                                                       // MakerGen.cs:232
                    Id = "MedicinalProductIndication.diseaseStatus",                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
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
                // 4. MedicinalProductIndication.comorbidity
                this.Element_Comorbidity = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Comorbidity",                                                                                           // MakerGen.cs:231
                    Path= "MedicinalProductIndication.comorbidity",                                                                         // MakerGen.cs:232
                    Id = "MedicinalProductIndication.comorbidity",                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. MedicinalProductIndication.intendedEffect
                this.Element_IntendedEffect = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_IntendedEffect",                                                                                        // MakerGen.cs:231
                    Path= "MedicinalProductIndication.intendedEffect",                                                                      // MakerGen.cs:232
                    Id = "MedicinalProductIndication.intendedEffect",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
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
                // 6. MedicinalProductIndication.duration
                this.Element_Duration = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Duration",                                                                                              // MakerGen.cs:231
                    Path= "MedicinalProductIndication.duration",                                                                            // MakerGen.cs:232
                    Id = "MedicinalProductIndication.duration",                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. MedicinalProductIndication.otherTherapy
                this.Element_OtherTherapy = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_OtherTherapy",                                                                                          // MakerGen.cs:231
                    Path= "MedicinalProductIndication.otherTherapy",                                                                        // MakerGen.cs:232
                    Id = "MedicinalProductIndication.otherTherapy",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_OtherTherapy                                                                                               // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. MedicinalProductIndication.undesirableEffect
                this.Element_UndesirableEffect = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_UndesirableEffect",                                                                                     // MakerGen.cs:231
                    Path= "MedicinalProductIndication.undesirableEffect",                                                                   // MakerGen.cs:232
                    Id = "MedicinalProductIndication.undesirableEffect",                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect"                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. MedicinalProductIndication.population
                this.Element_Population = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Population",                                                                                            // MakerGen.cs:231
                    Path= "MedicinalProductIndication.population",                                                                          // MakerGen.cs:232
                    Id = "MedicinalProductIndication.population",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Population                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "MedicinalProductIndication";                                                                                       // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication";                                                // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
