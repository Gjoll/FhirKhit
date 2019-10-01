using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
    {
      "resourceType": "StructureDefinition",
      "id": "MedicinalProductInteraction",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductInteraction",
      "version": "4.0.0",
      "name": "MedicinalProductInteraction",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "The interactions of the medicinal product with other medicinal products, or other forms of interactions.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductInteraction",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductInteraction",
            "path": "MedicinalProductInteraction",
            "short": "MedicinalProductInteraction",
            "definition": "The interactions of the medicinal product with other medicinal products, or other forms of interactions.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductInteraction.subject",
            "path": "MedicinalProductInteraction.subject",
            "short": "The medication for which this is a described interaction",
            "definition": "The medication for which this is a described interaction.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductInteraction.description",
            "path": "MedicinalProductInteraction.description",
            "short": "The interaction described",
            "definition": "The interaction described.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductInteraction.interactant",
            "path": "MedicinalProductInteraction.interactant",
            "short": "The specific medication, food or laboratory test that interacts",
            "definition": "The specific medication, food or laboratory test that interacts.",
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
            "id": "MedicinalProductInteraction.interactant.item[x]",
            "path": "MedicinalProductInteraction.interactant.item[x]",
            "short": "The specific medication, food or laboratory test that interacts",
            "definition": "The specific medication, food or laboratory test that interacts.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                ]
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductInteraction.type",
            "path": "MedicinalProductInteraction.type",
            "short": "The type of the interaction e.g. drug-drug interaction, drug-food interaction, drug-lab test interaction",
            "definition": "The type of the interaction e.g. drug-drug interaction, drug-food interaction, drug-lab test interaction.",
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
            "id": "MedicinalProductInteraction.effect",
            "path": "MedicinalProductInteraction.effect",
            "short": "The effect of the interaction, for example \"reduced gastric absorption of primary medication\"",
            "definition": "The effect of the interaction, for example \"reduced gastric absorption of primary medication\".",
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
            "id": "MedicinalProductInteraction.incidence",
            "path": "MedicinalProductInteraction.incidence",
            "short": "The incidence of the interaction, e.g. theoretical, observed",
            "definition": "The incidence of the interaction, e.g. theoretical, observed.",
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
            "id": "MedicinalProductInteraction.management",
            "path": "MedicinalProductInteraction.management",
            "short": "Actions for managing the interaction",
            "definition": "Actions for managing the interaction.",
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'MedicinalProductInteraction'
    /// </summary>
    // 0. MedicinalProductInteraction
    public class MedicinalProductInteraction : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class MedicinalProductInteraction_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 3. MedicinalProductInteraction.interactant
            public class Type_Interactant : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Interactant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 4. MedicinalProductInteraction.interactant.item[x]
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:216
                    public Type_Interactant_Elements()                                                                                      // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 4. MedicinalProductInteraction.interactant.item[x]
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Item",                                                                                              // MakerGen.cs:235
                                Path= "MedicinalProductInteraction.interactant.item[x]",                                                    // MakerGen.cs:236
                                Id = "MedicinalProductInteraction.interactant.item[x]",                                                     // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Medication",                                           // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Substance",                                            // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"                                 // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    },                                                                                                      // MakerGen.cs:350
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Interactant_Elements Elements { get; }                                                                          // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Interactant()                                                                                                   // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Interactant_Elements();                                                                        // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. MedicinalProductInteraction.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 2. MedicinalProductInteraction.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 3. MedicinalProductInteraction.interactant
            public ElementDefinitionInfo Interactant;                                                                                       // MakerGen.cs:216
            // 5. MedicinalProductInteraction.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 6. MedicinalProductInteraction.effect
            public ElementDefinitionInfo Effect;                                                                                            // MakerGen.cs:216
            // 7. MedicinalProductInteraction.incidence
            public ElementDefinitionInfo Incidence;                                                                                         // MakerGen.cs:216
            // 8. MedicinalProductInteraction.management
            public ElementDefinitionInfo Management;                                                                                        // MakerGen.cs:216
            public MedicinalProductInteraction_Elements()                                                                                   // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicinalProductInteraction.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "MedicinalProductInteraction.subject",                                                                        // MakerGen.cs:236
                        Id = "MedicinalProductInteraction.subject",                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MedicinalProductInteraction.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "MedicinalProductInteraction.description",                                                                    // MakerGen.cs:236
                        Id = "MedicinalProductInteraction.description",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. MedicinalProductInteraction.interactant
                    this.Interactant = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Interactant",                                                                                               // MakerGen.cs:235
                        Path= "MedicinalProductInteraction.interactant",                                                                    // MakerGen.cs:236
                        Id = "MedicinalProductInteraction.interactant",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Interactant                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. MedicinalProductInteraction.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "MedicinalProductInteraction.type",                                                                           // MakerGen.cs:236
                        Id = "MedicinalProductInteraction.type",                                                                            // MakerGen.cs:237
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
                    // 6. MedicinalProductInteraction.effect
                    this.Effect = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Effect",                                                                                                    // MakerGen.cs:235
                        Path= "MedicinalProductInteraction.effect",                                                                         // MakerGen.cs:236
                        Id = "MedicinalProductInteraction.effect",                                                                          // MakerGen.cs:237
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
                    // 7. MedicinalProductInteraction.incidence
                    this.Incidence = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Incidence",                                                                                                 // MakerGen.cs:235
                        Path= "MedicinalProductInteraction.incidence",                                                                      // MakerGen.cs:236
                        Id = "MedicinalProductInteraction.incidence",                                                                       // MakerGen.cs:237
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
                    // 8. MedicinalProductInteraction.management
                    this.Management = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Management",                                                                                                // MakerGen.cs:235
                        Path= "MedicinalProductInteraction.management",                                                                     // MakerGen.cs:236
                        Id = "MedicinalProductInteraction.management",                                                                      // MakerGen.cs:237
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
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                Interactant.Write(sDef);                                                                                                    // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Effect.Write(sDef);                                                                                                         // MakerGen.cs:220
                Incidence.Write(sDef);                                                                                                      // MakerGen.cs:220
                Management.Write(sDef);                                                                                                     // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public MedicinalProductInteraction_Elements Elements { get; }                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public MedicinalProductInteraction()                                                                                                // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new MedicinalProductInteraction_Elements();                                                                     // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
