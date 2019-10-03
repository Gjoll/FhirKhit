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
      "id": "MedicinalProductContraindication",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductContraindication",
      "version": "4.0.0",
      "name": "MedicinalProductContraindication",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "The clinical particulars - indications, contraindications etc. of a medicinal product, including for regulatory purposes.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductContraindication",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductContraindication",
            "path": "MedicinalProductContraindication",
            "short": "MedicinalProductContraindication",
            "definition": "The clinical particulars - indications, contraindications etc. of a medicinal product, including for regulatory purposes.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductContraindication.subject",
            "path": "MedicinalProductContraindication.subject",
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
            "id": "MedicinalProductContraindication.disease",
            "path": "MedicinalProductContraindication.disease",
            "short": "The disease, symptom or procedure for the contraindication",
            "definition": "The disease, symptom or procedure for the contraindication.",
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
            "id": "MedicinalProductContraindication.diseaseStatus",
            "path": "MedicinalProductContraindication.diseaseStatus",
            "short": "The status of the disease or symptom for the contraindication",
            "definition": "The status of the disease or symptom for the contraindication.",
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
            "id": "MedicinalProductContraindication.comorbidity",
            "path": "MedicinalProductContraindication.comorbidity",
            "short": "A comorbidity (concurrent condition) or coinfection",
            "definition": "A comorbidity (concurrent condition) or coinfection.",
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
            "id": "MedicinalProductContraindication.therapeuticIndication",
            "path": "MedicinalProductContraindication.therapeuticIndication",
            "short": "Information about the use of the medicinal product in relation to other therapies as part of the indication",
            "definition": "Information about the use of the medicinal product in relation to other therapies as part of the indication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductContraindication.otherTherapy",
            "path": "MedicinalProductContraindication.otherTherapy",
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
            "id": "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",
            "path": "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",
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
            "id": "MedicinalProductContraindication.otherTherapy.medication[x]",
            "path": "MedicinalProductContraindication.otherTherapy.medication[x]",
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
            "id": "MedicinalProductContraindication.population",
            "path": "MedicinalProductContraindication.population",
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
    /// Fhir resource 'MedicinalProductContraindication'
    /// </summary>
    // 0. MedicinalProductContraindication
    public partial class Resource_MedicinalProductContraindication : FhirKhit.Maker.Common.Resource.Resource_DomainResource                 // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 6. MedicinalProductContraindication.otherTherapy
        public partial class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 7. MedicinalProductContraindication.otherTherapy.therapyRelationshipType
            public ElementDefinitionInfo Element_TherapyRelationshipType;                                                                   // MakerGen.cs:217
            // 8. MedicinalProductContraindication.otherTherapy.medication[x]
            public ElementDefinitionInfo Element_Medication;                                                                                // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "MedicinalProductContraindication.otherTherapy",                                                                 // MakerGen.cs:393
                    ElementId = "MedicinalProductContraindication.otherTherapy"                                                             // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_TherapyRelationshipType.Write(sDef);                                                                                // MakerGen.cs:221
                Element_Medication.Write(sDef);                                                                                             // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_OtherTherapy()                                                                                                      // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 7. MedicinalProductContraindication.otherTherapy.therapyRelationshipType
                    this.Element_TherapyRelationshipType = new ElementDefinitionInfo                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_TherapyRelationshipType",                                                                           // MakerGen.cs:236
                        Path= "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",                                      // MakerGen.cs:237
                        Id = "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",                                       // MakerGen.cs:238
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
                    // 8. MedicinalProductContraindication.otherTherapy.medication[x]
                    this.Element_Medication = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Medication",                                                                                        // MakerGen.cs:236
                        Path= "MedicinalProductContraindication.otherTherapy.medication[x]",                                                // MakerGen.cs:237
                        Id = "MedicinalProductContraindication.otherTherapy.medication[x]",                                                 // MakerGen.cs:238
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
        // 1. MedicinalProductContraindication.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:217
        // 2. MedicinalProductContraindication.disease
        public ElementDefinitionInfo Element_Disease;                                                                                       // MakerGen.cs:217
        // 3. MedicinalProductContraindication.diseaseStatus
        public ElementDefinitionInfo Element_DiseaseStatus;                                                                                 // MakerGen.cs:217
        // 4. MedicinalProductContraindication.comorbidity
        public ElementDefinitionInfo Element_Comorbidity;                                                                                   // MakerGen.cs:217
        // 5. MedicinalProductContraindication.therapeuticIndication
        public ElementDefinitionInfo Element_TherapeuticIndication;                                                                         // MakerGen.cs:217
        // 6. MedicinalProductContraindication.otherTherapy
        public ElementDefinitionInfo Element_OtherTherapy;                                                                                  // MakerGen.cs:217
        // 9. MedicinalProductContraindication.population
        public ElementDefinitionInfo Element_Population;                                                                                    // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "MedicinalProductContraindication",                                                                                  // MakerGen.cs:393
                ElementId = "MedicinalProductContraindication"                                                                              // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Disease.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_DiseaseStatus.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_Comorbidity.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_TherapeuticIndication.Write(sDef);                                                                                      // MakerGen.cs:221
            Element_OtherTherapy.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Population.Write(sDef);                                                                                                 // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_MedicinalProductContraindication()                                                                                  // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. MedicinalProductContraindication.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:236
                    Path= "MedicinalProductContraindication.subject",                                                                       // MakerGen.cs:237
                    Id = "MedicinalProductContraindication.subject",                                                                        // MakerGen.cs:238
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
                // 2. MedicinalProductContraindication.disease
                this.Element_Disease = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Disease",                                                                                               // MakerGen.cs:236
                    Path= "MedicinalProductContraindication.disease",                                                                       // MakerGen.cs:237
                    Id = "MedicinalProductContraindication.disease",                                                                        // MakerGen.cs:238
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
                // 3. MedicinalProductContraindication.diseaseStatus
                this.Element_DiseaseStatus = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_DiseaseStatus",                                                                                         // MakerGen.cs:236
                    Path= "MedicinalProductContraindication.diseaseStatus",                                                                 // MakerGen.cs:237
                    Id = "MedicinalProductContraindication.diseaseStatus",                                                                  // MakerGen.cs:238
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
                // 4. MedicinalProductContraindication.comorbidity
                this.Element_Comorbidity = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Comorbidity",                                                                                           // MakerGen.cs:236
                    Path= "MedicinalProductContraindication.comorbidity",                                                                   // MakerGen.cs:237
                    Id = "MedicinalProductContraindication.comorbidity",                                                                    // MakerGen.cs:238
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
                // 5. MedicinalProductContraindication.therapeuticIndication
                this.Element_TherapeuticIndication = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_TherapeuticIndication",                                                                                 // MakerGen.cs:236
                    Path= "MedicinalProductContraindication.therapeuticIndication",                                                         // MakerGen.cs:237
                    Id = "MedicinalProductContraindication.therapeuticIndication",                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"                                        // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. MedicinalProductContraindication.otherTherapy
                this.Element_OtherTherapy = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_OtherTherapy",                                                                                          // MakerGen.cs:236
                    Path= "MedicinalProductContraindication.otherTherapy",                                                                  // MakerGen.cs:237
                    Id = "MedicinalProductContraindication.otherTherapy",                                                                   // MakerGen.cs:238
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
                // 9. MedicinalProductContraindication.population
                this.Element_Population = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Population",                                                                                            // MakerGen.cs:236
                    Path= "MedicinalProductContraindication.population",                                                                    // MakerGen.cs:237
                    Id = "MedicinalProductContraindication.population",                                                                     // MakerGen.cs:238
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
            this.Name = "MedicinalProductContraindication";                                                                                 // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductContraindication";                                          // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
