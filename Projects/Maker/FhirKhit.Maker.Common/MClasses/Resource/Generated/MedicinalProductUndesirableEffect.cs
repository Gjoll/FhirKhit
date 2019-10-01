using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
    {
      "resourceType": "StructureDefinition",
      "id": "MedicinalProductUndesirableEffect",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect",
      "version": "4.0.0",
      "name": "MedicinalProductUndesirableEffect",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Describe the undesirable effects of the medicinal product.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductUndesirableEffect",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductUndesirableEffect",
            "path": "MedicinalProductUndesirableEffect",
            "short": "MedicinalProductUndesirableEffect",
            "definition": "Describe the undesirable effects of the medicinal product.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductUndesirableEffect.subject",
            "path": "MedicinalProductUndesirableEffect.subject",
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
            "id": "MedicinalProductUndesirableEffect.symptomConditionEffect",
            "path": "MedicinalProductUndesirableEffect.symptomConditionEffect",
            "short": "The symptom, condition or undesirable effect",
            "definition": "The symptom, condition or undesirable effect.",
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
            "id": "MedicinalProductUndesirableEffect.classification",
            "path": "MedicinalProductUndesirableEffect.classification",
            "short": "Classification of the effect",
            "definition": "Classification of the effect.",
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
            "id": "MedicinalProductUndesirableEffect.frequencyOfOccurrence",
            "path": "MedicinalProductUndesirableEffect.frequencyOfOccurrence",
            "short": "The frequency of occurrence of the effect",
            "definition": "The frequency of occurrence of the effect.",
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
            "id": "MedicinalProductUndesirableEffect.population",
            "path": "MedicinalProductUndesirableEffect.population",
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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'MedicinalProductUndesirableEffect'
    /// </summary>
    // 0. MedicinalProductUndesirableEffect
    public class MedicinalProductUndesirableEffect : FhirKhit.Maker.Common.Resource.ResourceBase                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class MedicinalProductUndesirableEffect_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                               // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. MedicinalProductUndesirableEffect.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 2. MedicinalProductUndesirableEffect.symptomConditionEffect
            public ElementDefinitionInfo SymptomConditionEffect;                                                                            // MakerGen.cs:216
            // 3. MedicinalProductUndesirableEffect.classification
            public ElementDefinitionInfo Classification;                                                                                    // MakerGen.cs:216
            // 4. MedicinalProductUndesirableEffect.frequencyOfOccurrence
            public ElementDefinitionInfo FrequencyOfOccurrence;                                                                             // MakerGen.cs:216
            // 5. MedicinalProductUndesirableEffect.population
            public ElementDefinitionInfo Population;                                                                                        // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public MedicinalProductUndesirableEffect_Elements()                                                                             // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicinalProductUndesirableEffect.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "MedicinalProductUndesirableEffect.subject",                                                                  // MakerGen.cs:236
                        Id = "MedicinalProductUndesirableEffect.subject",                                                                   // MakerGen.cs:237
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
                    // 2. MedicinalProductUndesirableEffect.symptomConditionEffect
                    this.SymptomConditionEffect = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SymptomConditionEffect",                                                                                    // MakerGen.cs:235
                        Path= "MedicinalProductUndesirableEffect.symptomConditionEffect",                                                   // MakerGen.cs:236
                        Id = "MedicinalProductUndesirableEffect.symptomConditionEffect",                                                    // MakerGen.cs:237
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
                    // 3. MedicinalProductUndesirableEffect.classification
                    this.Classification = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Classification",                                                                                            // MakerGen.cs:235
                        Path= "MedicinalProductUndesirableEffect.classification",                                                           // MakerGen.cs:236
                        Id = "MedicinalProductUndesirableEffect.classification",                                                            // MakerGen.cs:237
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
                    // 4. MedicinalProductUndesirableEffect.frequencyOfOccurrence
                    this.FrequencyOfOccurrence = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "FrequencyOfOccurrence",                                                                                     // MakerGen.cs:235
                        Path= "MedicinalProductUndesirableEffect.frequencyOfOccurrence",                                                    // MakerGen.cs:236
                        Id = "MedicinalProductUndesirableEffect.frequencyOfOccurrence",                                                     // MakerGen.cs:237
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
                    // 5. MedicinalProductUndesirableEffect.population
                    this.Population = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Population",                                                                                                // MakerGen.cs:235
                        Path= "MedicinalProductUndesirableEffect.population",                                                               // MakerGen.cs:236
                        Id = "MedicinalProductUndesirableEffect.population",                                                                // MakerGen.cs:237
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
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                SymptomConditionEffect.Write(sDef);                                                                                         // MakerGen.cs:220
                Classification.Write(sDef);                                                                                                 // MakerGen.cs:220
                FrequencyOfOccurrence.Write(sDef);                                                                                          // MakerGen.cs:220
                Population.Write(sDef);                                                                                                     // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public MedicinalProductUndesirableEffect_Elements Elements                                                                          // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new MedicinalProductUndesirableEffect_Elements();                                                       // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        MedicinalProductUndesirableEffect_Elements elements;                                                                                // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public MedicinalProductUndesirableEffect()                                                                                          // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "MedicinalProductUndesirableEffect";                                                                                // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect";                                         // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "MedicinalProductUndesirableEffect",                                                                                 // MakerGen.cs:428
                ElementId = "MedicinalProductUndesirableEffect"                                                                             // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
