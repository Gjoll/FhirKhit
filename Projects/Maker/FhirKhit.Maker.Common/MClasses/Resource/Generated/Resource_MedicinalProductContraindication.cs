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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'MedicinalProductContraindication'
    /// </summary>
    // 0. MedicinalProductContraindication
    public class Resource_MedicinalProductContraindication : FhirKhit.Maker.Common.Resource.ResourceBase                                    // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_MedicinalProductContraindication_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                       // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 6. MedicinalProductContraindication.otherTherapy
            public class Type_OtherTherapy : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_OtherTherapy_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 7. MedicinalProductContraindication.otherTherapy.therapyRelationshipType
                    public ElementDefinitionInfo Element_TherapyRelationshipType;                                                           // MakerGen.cs:211
                    // 8. MedicinalProductContraindication.otherTherapy.medication[x]
                    public ElementDefinitionInfo Element_Medication;                                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_OtherTherapy_Elements()                                                                                     // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. MedicinalProductContraindication.otherTherapy.therapyRelationshipType
                            this.Element_TherapyRelationshipType = new ElementDefinitionInfo                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_TherapyRelationshipType",                                                                   // MakerGen.cs:230
                                Path= "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",                              // MakerGen.cs:231
                                Id = "MedicinalProductContraindication.otherTherapy.therapyRelationshipType",                               // MakerGen.cs:232
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
                            // 8. MedicinalProductContraindication.otherTherapy.medication[x]
                            this.Element_Medication = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Medication",                                                                                // MakerGen.cs:230
                                Path= "MedicinalProductContraindication.otherTherapy.medication[x]",                                        // MakerGen.cs:231
                                Id = "MedicinalProductContraindication.otherTherapy.medication[x]",                                         // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    },                                                                                                      // MakerGen.cs:314
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                     // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Medication",                                           // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Substance",                                            // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"                                // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_TherapyRelationshipType.Write(sDef);                                                                        // MakerGen.cs:215
                        Element_Medication.Write(sDef);                                                                                     // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_OtherTherapy_Elements Elements                                                                                  // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_OtherTherapy_Elements();                                                               // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_OtherTherapy_Elements elements;                                                                                        // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_OtherTherapy()                                                                                                  // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MedicinalProductContraindication.otherTherapy",                                                             // MakerGen.cs:420
                        ElementId = "MedicinalProductContraindication.otherTherapy"                                                         // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. MedicinalProductContraindication.subject
            public ElementDefinitionInfo Element_Subject;                                                                                   // MakerGen.cs:211
            // 2. MedicinalProductContraindication.disease
            public ElementDefinitionInfo Element_Disease;                                                                                   // MakerGen.cs:211
            // 3. MedicinalProductContraindication.diseaseStatus
            public ElementDefinitionInfo Element_DiseaseStatus;                                                                             // MakerGen.cs:211
            // 4. MedicinalProductContraindication.comorbidity
            public ElementDefinitionInfo Element_Comorbidity;                                                                               // MakerGen.cs:211
            // 5. MedicinalProductContraindication.therapeuticIndication
            public ElementDefinitionInfo Element_TherapeuticIndication;                                                                     // MakerGen.cs:211
            // 6. MedicinalProductContraindication.otherTherapy
            public ElementDefinitionInfo Element_OtherTherapy;                                                                              // MakerGen.cs:211
            // 9. MedicinalProductContraindication.population
            public ElementDefinitionInfo Element_Population;                                                                                // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_MedicinalProductContraindication_Elements()                                                                     // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. MedicinalProductContraindication.subject
                    this.Element_Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subject",                                                                                           // MakerGen.cs:230
                        Path= "MedicinalProductContraindication.subject",                                                                   // MakerGen.cs:231
                        Id = "MedicinalProductContraindication.subject",                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Medication"                                                    // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. MedicinalProductContraindication.disease
                    this.Element_Disease = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Disease",                                                                                           // MakerGen.cs:230
                        Path= "MedicinalProductContraindication.disease",                                                                   // MakerGen.cs:231
                        Id = "MedicinalProductContraindication.disease",                                                                    // MakerGen.cs:232
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
                    // 3. MedicinalProductContraindication.diseaseStatus
                    this.Element_DiseaseStatus = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_DiseaseStatus",                                                                                     // MakerGen.cs:230
                        Path= "MedicinalProductContraindication.diseaseStatus",                                                             // MakerGen.cs:231
                        Id = "MedicinalProductContraindication.diseaseStatus",                                                              // MakerGen.cs:232
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
                    // 4. MedicinalProductContraindication.comorbidity
                    this.Element_Comorbidity = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Comorbidity",                                                                                       // MakerGen.cs:230
                        Path= "MedicinalProductContraindication.comorbidity",                                                               // MakerGen.cs:231
                        Id = "MedicinalProductContraindication.comorbidity",                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. MedicinalProductContraindication.therapeuticIndication
                    this.Element_TherapeuticIndication = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_TherapeuticIndication",                                                                             // MakerGen.cs:230
                        Path= "MedicinalProductContraindication.therapeuticIndication",                                                     // MakerGen.cs:231
                        Id = "MedicinalProductContraindication.therapeuticIndication",                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"                                    // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. MedicinalProductContraindication.otherTherapy
                    this.Element_OtherTherapy = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_OtherTherapy",                                                                                      // MakerGen.cs:230
                        Path= "MedicinalProductContraindication.otherTherapy",                                                              // MakerGen.cs:231
                        Id = "MedicinalProductContraindication.otherTherapy",                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_OtherTherapy                                                                                           // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. MedicinalProductContraindication.population
                    this.Element_Population = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Population",                                                                                        // MakerGen.cs:230
                        Path= "MedicinalProductContraindication.population",                                                                // MakerGen.cs:231
                        Id = "MedicinalProductContraindication.population",                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Population                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Disease.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_DiseaseStatus.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_Comorbidity.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_TherapeuticIndication.Write(sDef);                                                                                  // MakerGen.cs:215
                Element_OtherTherapy.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Population.Write(sDef);                                                                                             // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_MedicinalProductContraindication_Elements Elements                                                                  // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_MedicinalProductContraindication_Elements();                                               // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_MedicinalProductContraindication_Elements elements;                                                                        // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_MedicinalProductContraindication()                                                                                  // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "MedicinalProductContraindication";                                                                                 // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductContraindication";                                          // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "MedicinalProductContraindication",                                                                                  // MakerGen.cs:420
                ElementId = "MedicinalProductContraindication"                                                                              // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
