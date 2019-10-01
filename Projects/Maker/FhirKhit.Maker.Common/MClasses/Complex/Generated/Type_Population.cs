using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
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
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'Population'
    /// </summary>
    // 0. Population
    public class Type_Population : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. Population.age[x]
        public ElementDefinitionInfo Element_Age;                                                                                           // MakerGen.cs:212
        // 2. Population.gender
        public ElementDefinitionInfo Element_Gender;                                                                                        // MakerGen.cs:212
        // 3. Population.race
        public ElementDefinitionInfo Element_Race;                                                                                          // MakerGen.cs:212
        // 4. Population.physiologicalCondition
        public ElementDefinitionInfo Element_PhysiologicalCondition;                                                                        // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Population",                                                                                                        // MakerGen.cs:388
                ElementId = "Population"                                                                                                    // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Age.Write(sDef);                                                                                                        // MakerGen.cs:216
            Element_Gender.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Race.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_PhysiologicalCondition.Write(sDef);                                                                                     // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_Population()                                                                                                            // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Population.age[x]
                this.Element_Age = new ElementDefinitionInfo                                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Age",                                                                                                   // MakerGen.cs:231
                    Path= "Population.age[x]",                                                                                              // MakerGen.cs:232
                    Id = "Population.age[x]",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Range                                                                        // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Population.gender
                this.Element_Gender = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Gender",                                                                                                // MakerGen.cs:231
                    Path= "Population.gender",                                                                                              // MakerGen.cs:232
                    Id = "Population.gender",                                                                                               // MakerGen.cs:233
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
                // 3. Population.race
                this.Element_Race = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Race",                                                                                                  // MakerGen.cs:231
                    Path= "Population.race",                                                                                                // MakerGen.cs:232
                    Id = "Population.race",                                                                                                 // MakerGen.cs:233
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
                // 4. Population.physiologicalCondition
                this.Element_PhysiologicalCondition = new ElementDefinitionInfo                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PhysiologicalCondition",                                                                                // MakerGen.cs:231
                    Path= "Population.physiologicalCondition",                                                                              // MakerGen.cs:232
                    Id = "Population.physiologicalCondition",                                                                               // MakerGen.cs:233
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
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
