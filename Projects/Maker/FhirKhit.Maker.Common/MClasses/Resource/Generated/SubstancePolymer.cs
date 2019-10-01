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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public class SubstancePolymer : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class SubstancePolymer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 5. SubstancePolymer.monomerSet
            public class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_MonomerSet_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    public class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_StartingMaterial_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                           // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 8. SubstancePolymer.monomerSet.startingMaterial.material
                            public ElementDefinitionInfo Material;                                                                          // MakerGen.cs:236
                            // 9. SubstancePolymer.monomerSet.startingMaterial.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:236
                            // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                            public ElementDefinitionInfo IsDefining;                                                                        // MakerGen.cs:236
                            // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:236
                            public Type_StartingMaterial_Elements()                                                                         // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 8. SubstancePolymer.monomerSet.startingMaterial.material
                                    this.Material = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Material",                                                                                  // MakerGen.cs:255
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.material",                                      // MakerGen.cs:256
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.material",                                       // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 9. SubstancePolymer.monomerSet.startingMaterial.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Type",                                                                                      // MakerGen.cs:255
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.type",                                          // MakerGen.cs:256
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.type",                                           // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                                    this.IsDefining = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "IsDefining",                                                                                // MakerGen.cs:255
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                    // MakerGen.cs:256
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                     // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Amount",                                                                                    // MakerGen.cs:255
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.amount",                                        // MakerGen.cs:256
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.amount",                                         // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.SubstanceAmount                                               // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Material.Write(sDef);                                                                                       // MakerGen.cs:240
                                Type.Write(sDef);                                                                                           // MakerGen.cs:240
                                IsDefining.Write(sDef);                                                                                     // MakerGen.cs:240
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_StartingMaterial_Elements Elements { get; }                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_StartingMaterial()                                                                                      // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_StartingMaterial_Elements();                                                           // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 6. SubstancePolymer.monomerSet.ratioType
                    public ElementDefinitionInfo RatioType;                                                                                 // MakerGen.cs:236
                    public Type_MonomerSet_Elements()                                                                                       // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 6. SubstancePolymer.monomerSet.ratioType
                            this.RatioType = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "RatioType",                                                                                         // MakerGen.cs:255
                                Path= "SubstancePolymer.monomerSet.ratioType",                                                              // MakerGen.cs:256
                                Id = "SubstancePolymer.monomerSet.ratioType",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
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
                        RatioType.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_MonomerSet_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_MonomerSet()                                                                                                    // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_MonomerSet_Elements();                                                                         // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 12. SubstancePolymer.repeat
            public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Repeat_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 16. SubstancePolymer.repeat.repeatUnit
                    public class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_RepeatUnit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                            public class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase                            // MakerGen.cs:385
                            {                                                                                                               // MakerGen.cs:386
                                public class Type_DegreeOfPolymerisation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase             // MakerGen.cs:387
                                {                                                                                                           // MakerGen.cs:388
                                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                                    public ElementDefinitionInfo Degree;                                                                    // MakerGen.cs:236
                                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                                    public ElementDefinitionInfo Amount;                                                                    // MakerGen.cs:236
                                    public Type_DegreeOfPolymerisation_Elements()                                                           // MakerGen.cs:409
                                    {                                                                                                       // MakerGen.cs:410
                                        {                                                                                                   // MakerGen.cs:251
                                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                                            this.Degree = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Degree",                                                                            // MakerGen.cs:255
                                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                   // MakerGen.cs:256
                                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                    // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:314
                                                    {                                                                                       // MakerGen.cs:315
                                                    }                                                                                       // MakerGen.cs:318
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                                            this.Amount = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Amount",                                                                            // MakerGen.cs:255
                                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                   // MakerGen.cs:256
                                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                    // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.SubstanceAmount                                       // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                    }                                                                                                       // MakerGen.cs:429
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:414
                                    {                                                                                                       // MakerGen.cs:415
                                        base.Write(sDef);                                                                                   // MakerGen.cs:416
                                        Degree.Write(sDef);                                                                                 // MakerGen.cs:240
                                        Amount.Write(sDef);                                                                                 // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:433
                                }                                                                                                           // MakerGen.cs:393
                                public Type_DegreeOfPolymerisation_Elements Elements { get; }                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                public Type_DegreeOfPolymerisation()                                                                        // MakerGen.cs:396
                                {                                                                                                           // MakerGen.cs:397
                                    this.Elements = new Type_DegreeOfPolymerisation_Elements();                                             // MakerGen.cs:398
                                }                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:403
                                }                                                                                                           // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                            // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                            public class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase                          // MakerGen.cs:385
                            {                                                                                                               // MakerGen.cs:386
                                public class Type_StructuralRepresentation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase           // MakerGen.cs:387
                                {                                                                                                           // MakerGen.cs:388
                                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:236
                                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                                    public ElementDefinitionInfo Representation;                                                            // MakerGen.cs:236
                                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                                    public ElementDefinitionInfo Attachment;                                                                // MakerGen.cs:236
                                    public Type_StructuralRepresentation_Elements()                                                         // MakerGen.cs:409
                                    {                                                                                                       // MakerGen.cs:410
                                        {                                                                                                   // MakerGen.cs:251
                                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Type",                                                                              // MakerGen.cs:255
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                   // MakerGen.cs:256
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                    // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:314
                                                    {                                                                                       // MakerGen.cs:315
                                                    }                                                                                       // MakerGen.cs:318
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                                            this.Representation = new ElementDefinitionInfo                                                 // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Representation",                                                                    // MakerGen.cs:255
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",         // MakerGen.cs:256
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                                            this.Attachment = new ElementDefinitionInfo                                                     // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Attachment",                                                                        // MakerGen.cs:255
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",             // MakerGen.cs:256
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",              // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Attachment                                            // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                    }                                                                                                       // MakerGen.cs:429
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:414
                                    {                                                                                                       // MakerGen.cs:415
                                        base.Write(sDef);                                                                                   // MakerGen.cs:416
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:240
                                        Representation.Write(sDef);                                                                         // MakerGen.cs:240
                                        Attachment.Write(sDef);                                                                             // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:433
                                }                                                                                                           // MakerGen.cs:393
                                public Type_StructuralRepresentation_Elements Elements { get; }                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                public Type_StructuralRepresentation()                                                                      // MakerGen.cs:396
                                {                                                                                                           // MakerGen.cs:397
                                    this.Elements = new Type_StructuralRepresentation_Elements();                                           // MakerGen.cs:398
                                }                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:403
                                }                                                                                                           // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                            // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                            public ElementDefinitionInfo OrientationOfPolymerisation;                                                       // MakerGen.cs:236
                            // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                            public ElementDefinitionInfo RepeatUnit;                                                                        // MakerGen.cs:236
                            // 19. SubstancePolymer.repeat.repeatUnit.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:236
                            public Type_RepeatUnit_Elements()                                                                               // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                                    this.OrientationOfPolymerisation = new ElementDefinitionInfo                                            // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "OrientationOfPolymerisation",                                                               // MakerGen.cs:255
                                        Path= "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                             // MakerGen.cs:256
                                        Id = "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                              // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                                    this.RepeatUnit = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "RepeatUnit",                                                                                // MakerGen.cs:255
                                        Path= "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                              // MakerGen.cs:256
                                        Id = "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                               // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 19. SubstancePolymer.repeat.repeatUnit.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Amount",                                                                                    // MakerGen.cs:255
                                        Path= "SubstancePolymer.repeat.repeatUnit.amount",                                                  // MakerGen.cs:256
                                        Id = "SubstancePolymer.repeat.repeatUnit.amount",                                                   // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.SubstanceAmount                                               // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                OrientationOfPolymerisation.Write(sDef);                                                                    // MakerGen.cs:240
                                RepeatUnit.Write(sDef);                                                                                     // MakerGen.cs:240
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_RepeatUnit_Elements Elements { get; }                                                                   // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_RepeatUnit()                                                                                            // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_RepeatUnit_Elements();                                                                 // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    public ElementDefinitionInfo NumberOfUnits;                                                                             // MakerGen.cs:236
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    public ElementDefinitionInfo AverageMolecularFormula;                                                                   // MakerGen.cs:236
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    public ElementDefinitionInfo RepeatUnitAmountType;                                                                      // MakerGen.cs:236
                    public Type_Repeat_Elements()                                                                                           // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. SubstancePolymer.repeat.numberOfUnits
                            this.NumberOfUnits = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "NumberOfUnits",                                                                                     // MakerGen.cs:255
                                Path= "SubstancePolymer.repeat.numberOfUnits",                                                              // MakerGen.cs:256
                                Id = "SubstancePolymer.repeat.numberOfUnits",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. SubstancePolymer.repeat.averageMolecularFormula
                            this.AverageMolecularFormula = new ElementDefinitionInfo                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "AverageMolecularFormula",                                                                           // MakerGen.cs:255
                                Path= "SubstancePolymer.repeat.averageMolecularFormula",                                                    // MakerGen.cs:256
                                Id = "SubstancePolymer.repeat.averageMolecularFormula",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 15. SubstancePolymer.repeat.repeatUnitAmountType
                            this.RepeatUnitAmountType = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "RepeatUnitAmountType",                                                                              // MakerGen.cs:255
                                Path= "SubstancePolymer.repeat.repeatUnitAmountType",                                                       // MakerGen.cs:256
                                Id = "SubstancePolymer.repeat.repeatUnitAmountType",                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
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
                        NumberOfUnits.Write(sDef);                                                                                          // MakerGen.cs:240
                        AverageMolecularFormula.Write(sDef);                                                                                // MakerGen.cs:240
                        RepeatUnitAmountType.Write(sDef);                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Repeat_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Repeat()                                                                                                        // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Repeat_Elements();                                                                             // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. SubstancePolymer.class
            public ElementDefinitionInfo Class;                                                                                             // MakerGen.cs:236
            // 2. SubstancePolymer.geometry
            public ElementDefinitionInfo Geometry;                                                                                          // MakerGen.cs:236
            // 3. SubstancePolymer.copolymerConnectivity
            public ElementDefinitionInfo CopolymerConnectivity;                                                                             // MakerGen.cs:236
            // 4. SubstancePolymer.modification
            public ElementDefinitionInfo Modification;                                                                                      // MakerGen.cs:236
            public SubstancePolymer_Elements()                                                                                              // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. SubstancePolymer.class
                    this.Class = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Class",                                                                                                     // MakerGen.cs:255
                        Path= "SubstancePolymer.class",                                                                                     // MakerGen.cs:256
                        Id = "SubstancePolymer.class",                                                                                      // MakerGen.cs:257
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
                    // 2. SubstancePolymer.geometry
                    this.Geometry = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Geometry",                                                                                                  // MakerGen.cs:255
                        Path= "SubstancePolymer.geometry",                                                                                  // MakerGen.cs:256
                        Id = "SubstancePolymer.geometry",                                                                                   // MakerGen.cs:257
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
                    // 3. SubstancePolymer.copolymerConnectivity
                    this.CopolymerConnectivity = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "CopolymerConnectivity",                                                                                     // MakerGen.cs:255
                        Path= "SubstancePolymer.copolymerConnectivity",                                                                     // MakerGen.cs:256
                        Id = "SubstancePolymer.copolymerConnectivity",                                                                      // MakerGen.cs:257
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
                    // 4. SubstancePolymer.modification
                    this.Modification = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Modification",                                                                                              // MakerGen.cs:255
                        Path= "SubstancePolymer.modification",                                                                              // MakerGen.cs:256
                        Id = "SubstancePolymer.modification",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Class.Write(sDef);                                                                                                          // MakerGen.cs:240
                Geometry.Write(sDef);                                                                                                       // MakerGen.cs:240
                CopolymerConnectivity.Write(sDef);                                                                                          // MakerGen.cs:240
                Modification.Write(sDef);                                                                                                   // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public SubstancePolymer_Elements Elements { get; }                                                                                  // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public SubstancePolymer()                                                                                                           // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new SubstancePolymer_Elements();                                                                                // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
