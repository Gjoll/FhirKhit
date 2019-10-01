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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'MedicinalProductContraindication'
    /// </summary>
    // 0. MedicinalProductContraindication
    public class MedicinalProductContraindication : FhirKhit.Maker.Common.Resource.ResourceBase                                             // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class MedicinalProductContraindication_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 6. MedicinalProductContraindication.otherTherapy
            public class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_OtherTherapy_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 7. MedicinalProductContraindication.otherTherapy.therapyRelationshipType
                    public ElementDefinitionInfo TherapyRelationshipType;                                                                   // MakerGen.cs:236
                    // 8. MedicinalProductContraindication.otherTherapy.medication[x]
                    public ElementDefinitionInfo Medication;                                                                                // MakerGen.cs:236
                    public Type_OtherTherapy_Elements()                                                                                     // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 7. MedicinalProductContraindication.otherTherapy.therapyRelationshipType
                            this.TherapyRelationshipType = new ElementDefinitionInfo                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "TherapyRelationshipType",                                                                           // MakerGen.cs:255
                                Path= "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",                              // MakerGen.cs:256
                                Id = "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",                               // MakerGen.cs:257
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
                            // 8. MedicinalProductContraindication.otherTherapy.medication[x]
                            this.Medication = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Medication",                                                                                        // MakerGen.cs:255
                                Path= "MedicinalProductContraindication.otherTherapy.medication[x]",                                        // MakerGen.cs:256
                                Id = "MedicinalProductContraindication.otherTherapy.medication[x]",                                         // MakerGen.cs:257
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
            // 1. MedicinalProductContraindication.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 2. MedicinalProductContraindication.disease
            public ElementDefinitionInfo Disease;                                                                                           // MakerGen.cs:236
            // 3. MedicinalProductContraindication.diseaseStatus
            public ElementDefinitionInfo DiseaseStatus;                                                                                     // MakerGen.cs:236
            // 4. MedicinalProductContraindication.comorbidity
            public ElementDefinitionInfo Comorbidity;                                                                                       // MakerGen.cs:236
            // 5. MedicinalProductContraindication.therapeuticIndication
            public ElementDefinitionInfo TherapeuticIndication;                                                                             // MakerGen.cs:236
            // 9. MedicinalProductContraindication.population
            public ElementDefinitionInfo Population;                                                                                        // MakerGen.cs:236
            public MedicinalProductContraindication_Elements()                                                                              // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. MedicinalProductContraindication.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "MedicinalProductContraindication.subject",                                                                   // MakerGen.cs:256
                        Id = "MedicinalProductContraindication.subject",                                                                    // MakerGen.cs:257
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
                    // 2. MedicinalProductContraindication.disease
                    this.Disease = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Disease",                                                                                                   // MakerGen.cs:255
                        Path= "MedicinalProductContraindication.disease",                                                                   // MakerGen.cs:256
                        Id = "MedicinalProductContraindication.disease",                                                                    // MakerGen.cs:257
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
                    // 3. MedicinalProductContraindication.diseaseStatus
                    this.DiseaseStatus = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DiseaseStatus",                                                                                             // MakerGen.cs:255
                        Path= "MedicinalProductContraindication.diseaseStatus",                                                             // MakerGen.cs:256
                        Id = "MedicinalProductContraindication.diseaseStatus",                                                              // MakerGen.cs:257
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
                    // 4. MedicinalProductContraindication.comorbidity
                    this.Comorbidity = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Comorbidity",                                                                                               // MakerGen.cs:255
                        Path= "MedicinalProductContraindication.comorbidity",                                                               // MakerGen.cs:256
                        Id = "MedicinalProductContraindication.comorbidity",                                                                // MakerGen.cs:257
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
                    // 5. MedicinalProductContraindication.therapeuticIndication
                    this.TherapeuticIndication = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "TherapeuticIndication",                                                                                     // MakerGen.cs:255
                        Path= "MedicinalProductContraindication.therapeuticIndication",                                                     // MakerGen.cs:256
                        Id = "MedicinalProductContraindication.therapeuticIndication",                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"                                    // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. MedicinalProductContraindication.population
                    this.Population = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Population",                                                                                                // MakerGen.cs:255
                        Path= "MedicinalProductContraindication.population",                                                                // MakerGen.cs:256
                        Id = "MedicinalProductContraindication.population",                                                                 // MakerGen.cs:257
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
                Disease.Write(sDef);                                                                                                        // MakerGen.cs:240
                DiseaseStatus.Write(sDef);                                                                                                  // MakerGen.cs:240
                Comorbidity.Write(sDef);                                                                                                    // MakerGen.cs:240
                TherapeuticIndication.Write(sDef);                                                                                          // MakerGen.cs:240
                Population.Write(sDef);                                                                                                     // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public MedicinalProductContraindication_Elements Elements { get; }                                                                  // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public MedicinalProductContraindication()                                                                                           // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new MedicinalProductContraindication_Elements();                                                                // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
