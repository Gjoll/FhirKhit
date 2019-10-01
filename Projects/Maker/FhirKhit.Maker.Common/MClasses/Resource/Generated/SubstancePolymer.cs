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
      "id": "SubstancePolymer",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstancePolymer",
      "version": "4.0.0",
      "name": "SubstancePolymer",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Todo.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstancePolymer",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstancePolymer",
            "path": "SubstancePolymer",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstancePolymer.class",
            "path": "SubstancePolymer.class",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.geometry",
            "path": "SubstancePolymer.geometry",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.copolymerConnectivity",
            "path": "SubstancePolymer.copolymerConnectivity",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.modification",
            "path": "SubstancePolymer.modification",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.monomerSet",
            "path": "SubstancePolymer.monomerSet",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.monomerSet.ratioType",
            "path": "SubstancePolymer.monomerSet.ratioType",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial",
            "path": "SubstancePolymer.monomerSet.startingMaterial",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.material",
            "path": "SubstancePolymer.monomerSet.startingMaterial.material",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.type",
            "path": "SubstancePolymer.monomerSet.startingMaterial.type",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.monomerSet.startingMaterial.isDefining",
            "path": "SubstancePolymer.monomerSet.startingMaterial.isDefining",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.monomerSet.startingMaterial.amount",
            "path": "SubstancePolymer.monomerSet.startingMaterial.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat",
            "path": "SubstancePolymer.repeat",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.numberOfUnits",
            "path": "SubstancePolymer.repeat.numberOfUnits",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.averageMolecularFormula",
            "path": "SubstancePolymer.repeat.averageMolecularFormula",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnitAmountType",
            "path": "SubstancePolymer.repeat.repeatUnitAmountType",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit",
            "path": "SubstancePolymer.repeat.repeatUnit",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",
            "path": "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.repeatUnit",
            "path": "SubstancePolymer.repeat.repeatUnit.repeatUnit",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.amount",
            "path": "SubstancePolymer.repeat.repeatUnit.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",
            "path": "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "SubstanceAmount"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",
            "short": "Todo",
            "definition": "Todo.",
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
            "id": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",
            "path": "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",
            "short": "Todo",
            "definition": "Todo.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
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
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public class SubstancePolymer : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class SubstancePolymer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 5. SubstancePolymer.monomerSet
            public class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_MonomerSet_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    public class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_StartingMaterial_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                           // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 8. SubstancePolymer.monomerSet.startingMaterial.material
                            public ElementDefinitionInfo Material;                                                                          // MakerGen.cs:216
                            // 9. SubstancePolymer.monomerSet.startingMaterial.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                            public ElementDefinitionInfo IsDefining;                                                                        // MakerGen.cs:216
                            // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:216
                            public Type_StartingMaterial_Elements()                                                                         // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 8. SubstancePolymer.monomerSet.startingMaterial.material
                                    this.Material = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Material",                                                                                  // MakerGen.cs:235
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.material",                                      // MakerGen.cs:236
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.material",                                       // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 9. SubstancePolymer.monomerSet.startingMaterial.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.type",                                          // MakerGen.cs:236
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.type",                                           // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                                    this.IsDefining = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "IsDefining",                                                                                // MakerGen.cs:235
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                    // MakerGen.cs:236
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Amount",                                                                                    // MakerGen.cs:235
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.amount",                                        // MakerGen.cs:236
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.amount",                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.SubstanceAmount                                               // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Material.Write(sDef);                                                                                       // MakerGen.cs:220
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                IsDefining.Write(sDef);                                                                                     // MakerGen.cs:220
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_StartingMaterial_Elements Elements { get; }                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_StartingMaterial()                                                                                      // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_StartingMaterial_Elements();                                                           // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 6. SubstancePolymer.monomerSet.ratioType
                    public ElementDefinitionInfo RatioType;                                                                                 // MakerGen.cs:216
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    public ElementDefinitionInfo StartingMaterial;                                                                          // MakerGen.cs:216
                    public Type_MonomerSet_Elements()                                                                                       // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 6. SubstancePolymer.monomerSet.ratioType
                            this.RatioType = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "RatioType",                                                                                         // MakerGen.cs:235
                                Path= "SubstancePolymer.monomerSet.ratioType",                                                              // MakerGen.cs:236
                                Id = "SubstancePolymer.monomerSet.ratioType",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 7. SubstancePolymer.monomerSet.startingMaterial
                            this.StartingMaterial = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "StartingMaterial",                                                                                  // MakerGen.cs:235
                                Path= "SubstancePolymer.monomerSet.startingMaterial",                                                       // MakerGen.cs:236
                                Id = "SubstancePolymer.monomerSet.startingMaterial",                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_StartingMaterial                                                                               // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        RatioType.Write(sDef);                                                                                              // MakerGen.cs:220
                        StartingMaterial.Write(sDef);                                                                                       // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_MonomerSet_Elements Elements { get; }                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_MonomerSet()                                                                                                    // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_MonomerSet_Elements();                                                                         // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 12. SubstancePolymer.repeat
            public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Repeat_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 16. SubstancePolymer.repeat.repeatUnit
                    public class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_RepeatUnit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                            public class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase                            // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_DegreeOfPolymerisation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase             // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                                    public ElementDefinitionInfo Degree;                                                                    // MakerGen.cs:216
                                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                                    public ElementDefinitionInfo Amount;                                                                    // MakerGen.cs:216
                                    public Type_DegreeOfPolymerisation_Elements()                                                           // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                                            this.Degree = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Degree",                                                                            // MakerGen.cs:235
                                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                   // MakerGen.cs:236
                                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                    // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                                            this.Amount = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Amount",                                                                            // MakerGen.cs:235
                                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                   // MakerGen.cs:236
                                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                    // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.SubstanceAmount                                       // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Degree.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Amount.Write(sDef);                                                                                 // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_DegreeOfPolymerisation_Elements Elements { get; }                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_DegreeOfPolymerisation()                                                                        // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_DegreeOfPolymerisation_Elements();                                             // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                            public class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase                          // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_StructuralRepresentation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase           // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:216
                                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                                    public ElementDefinitionInfo Representation;                                                            // MakerGen.cs:216
                                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                                    public ElementDefinitionInfo Attachment;                                                                // MakerGen.cs:216
                                    public Type_StructuralRepresentation_Elements()                                                         // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Type",                                                                              // MakerGen.cs:235
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                   // MakerGen.cs:236
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                    // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                                            this.Representation = new ElementDefinitionInfo                                                 // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Representation",                                                                    // MakerGen.cs:235
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",         // MakerGen.cs:236
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",          // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                                            this.Attachment = new ElementDefinitionInfo                                                     // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Attachment",                                                                        // MakerGen.cs:235
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",             // MakerGen.cs:236
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",              // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Attachment                                            // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:220
                                        Representation.Write(sDef);                                                                         // MakerGen.cs:220
                                        Attachment.Write(sDef);                                                                             // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_StructuralRepresentation_Elements Elements { get; }                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_StructuralRepresentation()                                                                      // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_StructuralRepresentation_Elements();                                           // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                            public ElementDefinitionInfo OrientationOfPolymerisation;                                                       // MakerGen.cs:216
                            // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                            public ElementDefinitionInfo RepeatUnit;                                                                        // MakerGen.cs:216
                            // 19. SubstancePolymer.repeat.repeatUnit.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:216
                            // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                            public ElementDefinitionInfo DegreeOfPolymerisation;                                                            // MakerGen.cs:216
                            // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                            public ElementDefinitionInfo StructuralRepresentation;                                                          // MakerGen.cs:216
                            public Type_RepeatUnit_Elements()                                                                               // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                                    this.OrientationOfPolymerisation = new ElementDefinitionInfo                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "OrientationOfPolymerisation",                                                               // MakerGen.cs:235
                                        Path= "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                             // MakerGen.cs:236
                                        Id = "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                                    this.RepeatUnit = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "RepeatUnit",                                                                                // MakerGen.cs:235
                                        Path= "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                              // MakerGen.cs:236
                                        Id = "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                               // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 19. SubstancePolymer.repeat.repeatUnit.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Amount",                                                                                    // MakerGen.cs:235
                                        Path= "SubstancePolymer.repeat.repeatUnit.amount",                                                  // MakerGen.cs:236
                                        Id = "SubstancePolymer.repeat.repeatUnit.amount",                                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.SubstanceAmount                                               // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                                    this.DegreeOfPolymerisation = new ElementDefinitionInfo                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "DegreeOfPolymerisation",                                                                    // MakerGen.cs:235
                                        Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                  // MakerGen.cs:236
                                        Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_DegreeOfPolymerisation                                                                 // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                                    this.StructuralRepresentation = new ElementDefinitionInfo                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "StructuralRepresentation",                                                                  // MakerGen.cs:235
                                        Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                // MakerGen.cs:236
                                        Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_StructuralRepresentation                                                               // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                OrientationOfPolymerisation.Write(sDef);                                                                    // MakerGen.cs:220
                                RepeatUnit.Write(sDef);                                                                                     // MakerGen.cs:220
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:220
                                DegreeOfPolymerisation.Write(sDef);                                                                         // MakerGen.cs:220
                                StructuralRepresentation.Write(sDef);                                                                       // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_RepeatUnit_Elements Elements { get; }                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_RepeatUnit()                                                                                            // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_RepeatUnit_Elements();                                                                 // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    public ElementDefinitionInfo NumberOfUnits;                                                                             // MakerGen.cs:216
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    public ElementDefinitionInfo AverageMolecularFormula;                                                                   // MakerGen.cs:216
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    public ElementDefinitionInfo RepeatUnitAmountType;                                                                      // MakerGen.cs:216
                    // 16. SubstancePolymer.repeat.repeatUnit
                    public ElementDefinitionInfo RepeatUnit;                                                                                // MakerGen.cs:216
                    public Type_Repeat_Elements()                                                                                           // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. SubstancePolymer.repeat.numberOfUnits
                            this.NumberOfUnits = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "NumberOfUnits",                                                                                     // MakerGen.cs:235
                                Path= "SubstancePolymer.repeat.numberOfUnits",                                                              // MakerGen.cs:236
                                Id = "SubstancePolymer.repeat.numberOfUnits",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. SubstancePolymer.repeat.averageMolecularFormula
                            this.AverageMolecularFormula = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AverageMolecularFormula",                                                                           // MakerGen.cs:235
                                Path= "SubstancePolymer.repeat.averageMolecularFormula",                                                    // MakerGen.cs:236
                                Id = "SubstancePolymer.repeat.averageMolecularFormula",                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. SubstancePolymer.repeat.repeatUnitAmountType
                            this.RepeatUnitAmountType = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "RepeatUnitAmountType",                                                                              // MakerGen.cs:235
                                Path= "SubstancePolymer.repeat.repeatUnitAmountType",                                                       // MakerGen.cs:236
                                Id = "SubstancePolymer.repeat.repeatUnitAmountType",                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. SubstancePolymer.repeat.repeatUnit
                            this.RepeatUnit = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "RepeatUnit",                                                                                        // MakerGen.cs:235
                                Path= "SubstancePolymer.repeat.repeatUnit",                                                                 // MakerGen.cs:236
                                Id = "SubstancePolymer.repeat.repeatUnit",                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_RepeatUnit                                                                                     // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        NumberOfUnits.Write(sDef);                                                                                          // MakerGen.cs:220
                        AverageMolecularFormula.Write(sDef);                                                                                // MakerGen.cs:220
                        RepeatUnitAmountType.Write(sDef);                                                                                   // MakerGen.cs:220
                        RepeatUnit.Write(sDef);                                                                                             // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Repeat_Elements Elements { get; }                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Repeat()                                                                                                        // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Repeat_Elements();                                                                             // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. SubstancePolymer.class
            public ElementDefinitionInfo Class;                                                                                             // MakerGen.cs:216
            // 2. SubstancePolymer.geometry
            public ElementDefinitionInfo Geometry;                                                                                          // MakerGen.cs:216
            // 3. SubstancePolymer.copolymerConnectivity
            public ElementDefinitionInfo CopolymerConnectivity;                                                                             // MakerGen.cs:216
            // 4. SubstancePolymer.modification
            public ElementDefinitionInfo Modification;                                                                                      // MakerGen.cs:216
            // 5. SubstancePolymer.monomerSet
            public ElementDefinitionInfo MonomerSet;                                                                                        // MakerGen.cs:216
            // 12. SubstancePolymer.repeat
            public ElementDefinitionInfo Repeat;                                                                                            // MakerGen.cs:216
            public SubstancePolymer_Elements()                                                                                              // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. SubstancePolymer.class
                    this.Class = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Class",                                                                                                     // MakerGen.cs:235
                        Path= "SubstancePolymer.class",                                                                                     // MakerGen.cs:236
                        Id = "SubstancePolymer.class",                                                                                      // MakerGen.cs:237
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
                    // 2. SubstancePolymer.geometry
                    this.Geometry = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Geometry",                                                                                                  // MakerGen.cs:235
                        Path= "SubstancePolymer.geometry",                                                                                  // MakerGen.cs:236
                        Id = "SubstancePolymer.geometry",                                                                                   // MakerGen.cs:237
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
                    // 3. SubstancePolymer.copolymerConnectivity
                    this.CopolymerConnectivity = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CopolymerConnectivity",                                                                                     // MakerGen.cs:235
                        Path= "SubstancePolymer.copolymerConnectivity",                                                                     // MakerGen.cs:236
                        Id = "SubstancePolymer.copolymerConnectivity",                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. SubstancePolymer.modification
                    this.Modification = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Modification",                                                                                              // MakerGen.cs:235
                        Path= "SubstancePolymer.modification",                                                                              // MakerGen.cs:236
                        Id = "SubstancePolymer.modification",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. SubstancePolymer.monomerSet
                    this.MonomerSet = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MonomerSet",                                                                                                // MakerGen.cs:235
                        Path= "SubstancePolymer.monomerSet",                                                                                // MakerGen.cs:236
                        Id = "SubstancePolymer.monomerSet",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_MonomerSet                                                                                             // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. SubstancePolymer.repeat
                    this.Repeat = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Repeat",                                                                                                    // MakerGen.cs:235
                        Path= "SubstancePolymer.repeat",                                                                                    // MakerGen.cs:236
                        Id = "SubstancePolymer.repeat",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Repeat                                                                                                 // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Class.Write(sDef);                                                                                                          // MakerGen.cs:220
                Geometry.Write(sDef);                                                                                                       // MakerGen.cs:220
                CopolymerConnectivity.Write(sDef);                                                                                          // MakerGen.cs:220
                Modification.Write(sDef);                                                                                                   // MakerGen.cs:220
                MonomerSet.Write(sDef);                                                                                                     // MakerGen.cs:220
                Repeat.Write(sDef);                                                                                                         // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public SubstancePolymer_Elements Elements { get; }                                                                                  // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public SubstancePolymer()                                                                                                           // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new SubstancePolymer_Elements();                                                                                // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
