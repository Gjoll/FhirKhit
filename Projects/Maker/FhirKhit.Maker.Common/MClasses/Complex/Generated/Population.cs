using System;                                                                                                                               // MakerGen.cs:499
using System.Diagnostics;                                                                                                                   // MakerGen.cs:500
using System.IO;                                                                                                                            // MakerGen.cs:501
using System.Linq;                                                                                                                          // MakerGen.cs:502
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:503
                                                                                                                                            // MakerGen.cs:504
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:505
{                                                                                                                                           // MakerGen.cs:506
    #region Json                                                                                                                            // MakerGen.cs:507
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
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'Population'
    /// </summary>
    // 0. Population
    public class Population : FhirKhit.Maker.Common.Complex.ComplexBase                                                                     // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Population_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                      // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Population.age[x]
            public ElementDefinitionInfo Age;                                                                                               // MakerGen.cs:236
            // 2. Population.gender
            public ElementDefinitionInfo Gender;                                                                                            // MakerGen.cs:236
            // 3. Population.race
            public ElementDefinitionInfo Race;                                                                                              // MakerGen.cs:236
            // 4. Population.physiologicalCondition
            public ElementDefinitionInfo PhysiologicalCondition;                                                                            // MakerGen.cs:236
            public Population_Elements()                                                                                                    // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Population.age[x]
                    this.Age = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Age",                                                                                                       // MakerGen.cs:255
                        Path= "Population.age[x]",                                                                                          // MakerGen.cs:256
                        Id = "Population.age[x]",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. Population.gender
                    this.Gender = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Gender",                                                                                                    // MakerGen.cs:255
                        Path= "Population.gender",                                                                                          // MakerGen.cs:256
                        Id = "Population.gender",                                                                                           // MakerGen.cs:257
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
                    // 3. Population.race
                    this.Race = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Race",                                                                                                      // MakerGen.cs:255
                        Path= "Population.race",                                                                                            // MakerGen.cs:256
                        Id = "Population.race",                                                                                             // MakerGen.cs:257
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
                    // 4. Population.physiologicalCondition
                    this.PhysiologicalCondition = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PhysiologicalCondition",                                                                                    // MakerGen.cs:255
                        Path= "Population.physiologicalCondition",                                                                          // MakerGen.cs:256
                        Id = "Population.physiologicalCondition",                                                                           // MakerGen.cs:257
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
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Age.Write(sDef);                                                                                                            // MakerGen.cs:240
                Gender.Write(sDef);                                                                                                         // MakerGen.cs:240
                Race.Write(sDef);                                                                                                           // MakerGen.cs:240
                PhysiologicalCondition.Write(sDef);                                                                                         // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Population_Elements Elements { get; }                                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Population()                                                                                                                 // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Population_Elements();                                                                                      // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
