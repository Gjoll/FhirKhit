using System;                                                                                                                               // MakerGen.cs:423
using System.Diagnostics;                                                                                                                   // MakerGen.cs:424
using System.IO;                                                                                                                            // MakerGen.cs:425
using System.Linq;                                                                                                                          // MakerGen.cs:426
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:427
                                                                                                                                            // MakerGen.cs:428
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:429
{                                                                                                                                           // MakerGen.cs:430
    #region Json                                                                                                                            // MakerGen.cs:431
    #if NEVER                                                                                                                               // MakerGen.cs:432
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
    #endregion                                                                                                                              // MakerGen.cs:435
    /// <summary>
    /// Fhir resource 'MedicinalProductUndesirableEffect'
    /// </summary>
    // 0. MedicinalProductUndesirableEffect
    public class MedicinalProductUndesirableEffect : FhirKhit.Maker.Common.Resource.ResourceBase                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 1. MedicinalProductUndesirableEffect.subject
        public MakerElementInstance Element_Subject;                                                                                        // MakerGen.cs:232
        // 2. MedicinalProductUndesirableEffect.symptomConditionEffect
        public MakerElementInstance Element_SymptomConditionEffect;                                                                         // MakerGen.cs:232
        // 3. MedicinalProductUndesirableEffect.classification
        public MakerElementInstance Element_Classification;                                                                                 // MakerGen.cs:232
        // 4. MedicinalProductUndesirableEffect.frequencyOfOccurrence
        public MakerElementInstance Element_FrequencyOfOccurrence;                                                                          // MakerGen.cs:232
        // 5. MedicinalProductUndesirableEffect.population
        public MakerElementInstance Element_Population;                                                                                     // MakerGen.cs:232
        public MedicinalProductUndesirableEffect()                                                                                          // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. MedicinalProductUndesirableEffect.subject
                this.Element_Subject = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 2. MedicinalProductUndesirableEffect.symptomConditionEffect
                this.Element_SymptomConditionEffect = new MakerElementInstance                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SymptomConditionEffect",                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 3. MedicinalProductUndesirableEffect.classification
                this.Element_Classification = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Classification",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 4. MedicinalProductUndesirableEffect.frequencyOfOccurrence
                this.Element_FrequencyOfOccurrence = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_FrequencyOfOccurrence",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 5. MedicinalProductUndesirableEffect.population
                this.Element_Population = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Population",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Population                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:440
