using System;                                                                                                                               // MakerGen.cs:471
using System.Diagnostics;                                                                                                                   // MakerGen.cs:472
using System.IO;                                                                                                                            // MakerGen.cs:473
using System.Linq;                                                                                                                          // MakerGen.cs:474
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:475
                                                                                                                                            // MakerGen.cs:476
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:477
{                                                                                                                                           // MakerGen.cs:478
    #region Json                                                                                                                            // MakerGen.cs:479
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Population",
      "url": "http://hl7.org/fhir/StructureDefinition/Population",
      "version": "4.0.0",
      "name": "Population",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Population Type: A populatioof people with some set of grouping criteria.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Population",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Population",
            "path": "Population",
            "short": "A definition of a set of people that apply to some clinically related context, for example people contraindicated for a certain medication",
            "definition": "A populatioof people with some set of grouping criteria.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Population.age[x]",
            "path": "Population.age[x]",
            "short": "The age of the specific population",
            "definition": "The age of the specific population.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Range"
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Population.gender",
            "path": "Population.gender",
            "short": "The gender of the specific population",
            "definition": "The gender of the specific population.",
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
            "id": "Population.race",
            "path": "Population.race",
            "short": "Race of the specific population",
            "definition": "Race of the specific population.",
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
            "id": "Population.physiologicalCondition",
            "path": "Population.physiologicalCondition",
            "short": "The existing physiological conditions of the specific population to which this applies",
            "definition": "The existing physiological conditions of the specific population to which this applies.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:483
    /// <summary>
    /// Fhir complex 'Population'
    /// </summary>
    // 0. Population
    public class Population : FhirKhit.Maker.Common.Complex.ComplexBase                                                                     // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 1. Population.age[x]
        public MakerElementInstance Element_Age;                                                                                            // MakerGen.cs:232
        // 2. Population.gender
        public MakerElementInstance Element_Gender;                                                                                         // MakerGen.cs:232
        // 3. Population.race
        public MakerElementInstance Element_Race;                                                                                           // MakerGen.cs:232
        // 4. Population.physiologicalCondition
        public MakerElementInstance Element_PhysiologicalCondition;                                                                         // MakerGen.cs:232
        public Population()                                                                                                                 // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. Population.age[x]
                this.Element_Age = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Age",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Range                                                                             // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        },                                                                                                                  // MakerGen.cs:345
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 2. Population.gender
                this.Element_Gender = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Gender",                                                                                                // MakerGen.cs:247
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
                // 3. Population.race
                this.Element_Race = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Race",                                                                                                  // MakerGen.cs:247
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
                // 4. Population.physiologicalCondition
                this.Element_PhysiologicalCondition = new MakerElementInstance                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PhysiologicalCondition",                                                                                // MakerGen.cs:247
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
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:488
