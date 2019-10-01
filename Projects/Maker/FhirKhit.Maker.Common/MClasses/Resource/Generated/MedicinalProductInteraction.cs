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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'MedicinalProductInteraction'
    /// </summary>
    // 0. MedicinalProductInteraction
    public class MedicinalProductInteraction : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class MedicinalProductInteraction_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 3. MedicinalProductInteraction.interactant
            public class Type_Interactant : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Interactant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 4. MedicinalProductInteraction.interactant.item[x]
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:236
                    public Type_Interactant_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 4. MedicinalProductInteraction.interactant.item[x]
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Item",                                                                                              // MakerGen.cs:255
                                Path= "MedicinalProductInteraction.interactant.item[x]",                                                    // MakerGen.cs:256
                                Id = "MedicinalProductInteraction.interactant.item[x]",                                                     // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                     // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Medication",                                           // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Substance",                                            // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"                                 // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Interactant_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Interactant()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Interactant_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. MedicinalProductInteraction.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 2. MedicinalProductInteraction.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:236
            // 5. MedicinalProductInteraction.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:236
            // 6. MedicinalProductInteraction.effect
            public ElementDefinitionInfo Effect;                                                                                            // MakerGen.cs:236
            // 7. MedicinalProductInteraction.incidence
            public ElementDefinitionInfo Incidence;                                                                                         // MakerGen.cs:236
            // 8. MedicinalProductInteraction.management
            public ElementDefinitionInfo Management;                                                                                        // MakerGen.cs:236
            public MedicinalProductInteraction_Elements()                                                                                   // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. MedicinalProductInteraction.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "MedicinalProductInteraction.subject",                                                                        // MakerGen.cs:256
                        Id = "MedicinalProductInteraction.subject",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. MedicinalProductInteraction.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Description",                                                                                               // MakerGen.cs:255
                        Path= "MedicinalProductInteraction.description",                                                                    // MakerGen.cs:256
                        Id = "MedicinalProductInteraction.description",                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. MedicinalProductInteraction.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Type",                                                                                                      // MakerGen.cs:255
                        Path= "MedicinalProductInteraction.type",                                                                           // MakerGen.cs:256
                        Id = "MedicinalProductInteraction.type",                                                                            // MakerGen.cs:257
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
                    // 6. MedicinalProductInteraction.effect
                    this.Effect = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Effect",                                                                                                    // MakerGen.cs:255
                        Path= "MedicinalProductInteraction.effect",                                                                         // MakerGen.cs:256
                        Id = "MedicinalProductInteraction.effect",                                                                          // MakerGen.cs:257
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
                    // 7. MedicinalProductInteraction.incidence
                    this.Incidence = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Incidence",                                                                                                 // MakerGen.cs:255
                        Path= "MedicinalProductInteraction.incidence",                                                                      // MakerGen.cs:256
                        Id = "MedicinalProductInteraction.incidence",                                                                       // MakerGen.cs:257
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
                    // 8. MedicinalProductInteraction.management
                    this.Management = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Management",                                                                                                // MakerGen.cs:255
                        Path= "MedicinalProductInteraction.management",                                                                     // MakerGen.cs:256
                        Id = "MedicinalProductInteraction.management",                                                                      // MakerGen.cs:257
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
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Description.Write(sDef);                                                                                                    // MakerGen.cs:240
                Type.Write(sDef);                                                                                                           // MakerGen.cs:240
                Effect.Write(sDef);                                                                                                         // MakerGen.cs:240
                Incidence.Write(sDef);                                                                                                      // MakerGen.cs:240
                Management.Write(sDef);                                                                                                     // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public MedicinalProductInteraction_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public MedicinalProductInteraction()                                                                                                // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new MedicinalProductInteraction_Elements();                                                                     // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
