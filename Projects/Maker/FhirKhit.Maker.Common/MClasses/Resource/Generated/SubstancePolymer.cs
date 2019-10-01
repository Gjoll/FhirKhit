using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public class SubstancePolymer : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class SubstancePolymer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 5. SubstancePolymer.monomerSet
            public class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_MonomerSet_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    public class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_StartingMaterial_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                           // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 8. SubstancePolymer.monomerSet.startingMaterial.material
                            public ElementDefinitionInfo Material;                                                                          // MakerGen.cs:211
                            // 9. SubstancePolymer.monomerSet.startingMaterial.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:211
                            // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                            public ElementDefinitionInfo IsDefining;                                                                        // MakerGen.cs:211
                            // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_StartingMaterial_Elements()                                                                         // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 8. SubstancePolymer.monomerSet.startingMaterial.material
                                    this.Material = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Material",                                                                                  // MakerGen.cs:230
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.material",                                      // MakerGen.cs:231
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.material",                                       // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 9. SubstancePolymer.monomerSet.startingMaterial.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Type",                                                                                      // MakerGen.cs:230
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.type",                                          // MakerGen.cs:231
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.type",                                           // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                                    this.IsDefining = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "IsDefining",                                                                                // MakerGen.cs:230
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                    // MakerGen.cs:231
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                     // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Amount",                                                                                    // MakerGen.cs:230
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.amount",                                        // MakerGen.cs:231
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.amount",                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.SubstanceAmount                                               // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Material.Write(sDef);                                                                                       // MakerGen.cs:215
                                Type.Write(sDef);                                                                                           // MakerGen.cs:215
                                IsDefining.Write(sDef);                                                                                     // MakerGen.cs:215
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_StartingMaterial_Elements Elements                                                                      // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_StartingMaterial_Elements();                                                   // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_StartingMaterial_Elements elements;                                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_StartingMaterial()                                                                                      // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "SubstancePolymer.monomerSet.startingMaterial",                                                      // MakerGen.cs:423
                                ElementId = "SubstancePolymer.monomerSet.startingMaterial"                                                  // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 6. SubstancePolymer.monomerSet.ratioType
                    public ElementDefinitionInfo RatioType;                                                                                 // MakerGen.cs:211
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    public ElementDefinitionInfo StartingMaterial;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_MonomerSet_Elements()                                                                                       // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 6. SubstancePolymer.monomerSet.ratioType
                            this.RatioType = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "RatioType",                                                                                         // MakerGen.cs:230
                                Path= "SubstancePolymer.monomerSet.ratioType",                                                              // MakerGen.cs:231
                                Id = "SubstancePolymer.monomerSet.ratioType",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. SubstancePolymer.monomerSet.startingMaterial
                            this.StartingMaterial = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "StartingMaterial",                                                                                  // MakerGen.cs:230
                                Path= "SubstancePolymer.monomerSet.startingMaterial",                                                       // MakerGen.cs:231
                                Id = "SubstancePolymer.monomerSet.startingMaterial",                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_StartingMaterial                                                                               // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        RatioType.Write(sDef);                                                                                              // MakerGen.cs:215
                        StartingMaterial.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_MonomerSet_Elements Elements                                                                                    // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_MonomerSet_Elements();                                                                 // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_MonomerSet_Elements elements;                                                                                          // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_MonomerSet()                                                                                                    // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstancePolymer.monomerSet",                                                                               // MakerGen.cs:423
                        ElementId = "SubstancePolymer.monomerSet"                                                                           // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 12. SubstancePolymer.repeat
            public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Repeat_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 16. SubstancePolymer.repeat.repeatUnit
                    public class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_RepeatUnit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                            public class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase                            // MakerGen.cs:379
                            {                                                                                                               // MakerGen.cs:380
                                public class Type_DegreeOfPolymerisation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase             // MakerGen.cs:381
                                {                                                                                                           // MakerGen.cs:382
                                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                                    public ElementDefinitionInfo Degree;                                                                    // MakerGen.cs:211
                                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                                    public ElementDefinitionInfo Amount;                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                                    public Type_DegreeOfPolymerisation_Elements()                                                           // MakerGen.cs:387
                                    {                                                                                                       // MakerGen.cs:388
                                        {                                                                                                   // MakerGen.cs:226
                                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                                            this.Degree = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Degree",                                                                            // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                   // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                                            this.Amount = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Amount",                                                                            // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                   // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.SubstanceAmount                                       // MakerGen.cs:353
                                                    {                                                                                       // MakerGen.cs:354
                                                    }                                                                                       // MakerGen.cs:355
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:393
                                    {                                                                                                       // MakerGen.cs:394
                                        base.Write(sDef);                                                                                   // MakerGen.cs:395
                                        Degree.Write(sDef);                                                                                 // MakerGen.cs:215
                                        Amount.Write(sDef);                                                                                 // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:397
                                }                                                                                                           // MakerGen.cs:399
                                public Type_DegreeOfPolymerisation_Elements Elements                                                        // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    get                                                                                                     // MakerGen.cs:403
                                    {                                                                                                       // MakerGen.cs:404
                                        if (this.elements == null)                                                                          // MakerGen.cs:405
                                            this.elements = new Type_DegreeOfPolymerisation_Elements();                                     // MakerGen.cs:406
                                        return this.elements;                                                                               // MakerGen.cs:407
                                    }                                                                                                       // MakerGen.cs:408
                                }                                                                                                           // MakerGen.cs:409
                                Type_DegreeOfPolymerisation_Elements elements;                                                              // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                                public Type_DegreeOfPolymerisation()                                                                        // MakerGen.cs:413
                                {                                                                                                           // MakerGen.cs:414
                                }                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:419
                                {                                                                                                           // MakerGen.cs:420
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:421
                                    {                                                                                                       // MakerGen.cs:422
                                        Path = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                 // MakerGen.cs:423
                                        ElementId = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation"                             // MakerGen.cs:424
                                    });                                                                                                     // MakerGen.cs:425
                                    if (this.elements != null)                                                                              // MakerGen.cs:426
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:427
                                }                                                                                                           // MakerGen.cs:428
                            }                                                                                                               // MakerGen.cs:429
                            // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                            public class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase                          // MakerGen.cs:379
                            {                                                                                                               // MakerGen.cs:380
                                public class Type_StructuralRepresentation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase           // MakerGen.cs:381
                                {                                                                                                           // MakerGen.cs:382
                                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:211
                                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                                    public ElementDefinitionInfo Representation;                                                            // MakerGen.cs:211
                                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                                    public ElementDefinitionInfo Attachment;                                                                // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                                    public Type_StructuralRepresentation_Elements()                                                         // MakerGen.cs:387
                                    {                                                                                                       // MakerGen.cs:388
                                        {                                                                                                   // MakerGen.cs:226
                                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Type",                                                                              // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                   // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                                            this.Representation = new ElementDefinitionInfo                                                 // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Representation",                                                                    // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",         // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",          // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:295
                                                    {                                                                                       // MakerGen.cs:296
                                                    }                                                                                       // MakerGen.cs:299
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                                            this.Attachment = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Attachment",                                                                        // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",             // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",              // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Attachment                                            // MakerGen.cs:353
                                                    {                                                                                       // MakerGen.cs:354
                                                    }                                                                                       // MakerGen.cs:355
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:393
                                    {                                                                                                       // MakerGen.cs:394
                                        base.Write(sDef);                                                                                   // MakerGen.cs:395
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:215
                                        Representation.Write(sDef);                                                                         // MakerGen.cs:215
                                        Attachment.Write(sDef);                                                                             // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:397
                                }                                                                                                           // MakerGen.cs:399
                                public Type_StructuralRepresentation_Elements Elements                                                      // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    get                                                                                                     // MakerGen.cs:403
                                    {                                                                                                       // MakerGen.cs:404
                                        if (this.elements == null)                                                                          // MakerGen.cs:405
                                            this.elements = new Type_StructuralRepresentation_Elements();                                   // MakerGen.cs:406
                                        return this.elements;                                                                               // MakerGen.cs:407
                                    }                                                                                                       // MakerGen.cs:408
                                }                                                                                                           // MakerGen.cs:409
                                Type_StructuralRepresentation_Elements elements;                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                                public Type_StructuralRepresentation()                                                                      // MakerGen.cs:413
                                {                                                                                                           // MakerGen.cs:414
                                }                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:419
                                {                                                                                                           // MakerGen.cs:420
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:421
                                    {                                                                                                       // MakerGen.cs:422
                                        Path = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                               // MakerGen.cs:423
                                        ElementId = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation"                           // MakerGen.cs:424
                                    });                                                                                                     // MakerGen.cs:425
                                    if (this.elements != null)                                                                              // MakerGen.cs:426
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:427
                                }                                                                                                           // MakerGen.cs:428
                            }                                                                                                               // MakerGen.cs:429
                            // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                            public ElementDefinitionInfo OrientationOfPolymerisation;                                                       // MakerGen.cs:211
                            // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                            public ElementDefinitionInfo RepeatUnit;                                                                        // MakerGen.cs:211
                            // 19. SubstancePolymer.repeat.repeatUnit.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:211
                            // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                            public ElementDefinitionInfo DegreeOfPolymerisation;                                                            // MakerGen.cs:211
                            // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                            public ElementDefinitionInfo StructuralRepresentation;                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_RepeatUnit_Elements()                                                                               // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                                    this.OrientationOfPolymerisation = new ElementDefinitionInfo                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "OrientationOfPolymerisation",                                                               // MakerGen.cs:230
                                        Path= "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                             // MakerGen.cs:231
                                        Id = "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                                    this.RepeatUnit = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "RepeatUnit",                                                                                // MakerGen.cs:230
                                        Path= "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                              // MakerGen.cs:231
                                        Id = "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 19. SubstancePolymer.repeat.repeatUnit.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Amount",                                                                                    // MakerGen.cs:230
                                        Path= "SubstancePolymer.repeat.repeatUnit.amount",                                                  // MakerGen.cs:231
                                        Id = "SubstancePolymer.repeat.repeatUnit.amount",                                                   // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.SubstanceAmount                                               // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                                    this.DegreeOfPolymerisation = new ElementDefinitionInfo                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "DegreeOfPolymerisation",                                                                    // MakerGen.cs:230
                                        Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                  // MakerGen.cs:231
                                        Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                   // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_DegreeOfPolymerisation                                                                 // MakerGen.cs:254
                                            {                                                                                               // MakerGen.cs:255
                                            }                                                                                               // MakerGen.cs:256
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                                    this.StructuralRepresentation = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "StructuralRepresentation",                                                                  // MakerGen.cs:230
                                        Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                // MakerGen.cs:231
                                        Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                 // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_StructuralRepresentation                                                               // MakerGen.cs:254
                                            {                                                                                               // MakerGen.cs:255
                                            }                                                                                               // MakerGen.cs:256
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                OrientationOfPolymerisation.Write(sDef);                                                                    // MakerGen.cs:215
                                RepeatUnit.Write(sDef);                                                                                     // MakerGen.cs:215
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:215
                                DegreeOfPolymerisation.Write(sDef);                                                                         // MakerGen.cs:215
                                StructuralRepresentation.Write(sDef);                                                                       // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_RepeatUnit_Elements Elements                                                                            // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_RepeatUnit_Elements();                                                         // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_RepeatUnit_Elements elements;                                                                                  // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_RepeatUnit()                                                                                            // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "SubstancePolymer.repeat.repeatUnit",                                                                // MakerGen.cs:423
                                ElementId = "SubstancePolymer.repeat.repeatUnit"                                                            // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    public ElementDefinitionInfo NumberOfUnits;                                                                             // MakerGen.cs:211
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    public ElementDefinitionInfo AverageMolecularFormula;                                                                   // MakerGen.cs:211
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    public ElementDefinitionInfo RepeatUnitAmountType;                                                                      // MakerGen.cs:211
                    // 16. SubstancePolymer.repeat.repeatUnit
                    public ElementDefinitionInfo RepeatUnit;                                                                                // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Repeat_Elements()                                                                                           // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. SubstancePolymer.repeat.numberOfUnits
                            this.NumberOfUnits = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "NumberOfUnits",                                                                                     // MakerGen.cs:230
                                Path= "SubstancePolymer.repeat.numberOfUnits",                                                              // MakerGen.cs:231
                                Id = "SubstancePolymer.repeat.numberOfUnits",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. SubstancePolymer.repeat.averageMolecularFormula
                            this.AverageMolecularFormula = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AverageMolecularFormula",                                                                           // MakerGen.cs:230
                                Path= "SubstancePolymer.repeat.averageMolecularFormula",                                                    // MakerGen.cs:231
                                Id = "SubstancePolymer.repeat.averageMolecularFormula",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 15. SubstancePolymer.repeat.repeatUnitAmountType
                            this.RepeatUnitAmountType = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "RepeatUnitAmountType",                                                                              // MakerGen.cs:230
                                Path= "SubstancePolymer.repeat.repeatUnitAmountType",                                                       // MakerGen.cs:231
                                Id = "SubstancePolymer.repeat.repeatUnitAmountType",                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. SubstancePolymer.repeat.repeatUnit
                            this.RepeatUnit = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "RepeatUnit",                                                                                        // MakerGen.cs:230
                                Path= "SubstancePolymer.repeat.repeatUnit",                                                                 // MakerGen.cs:231
                                Id = "SubstancePolymer.repeat.repeatUnit",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_RepeatUnit                                                                                     // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        NumberOfUnits.Write(sDef);                                                                                          // MakerGen.cs:215
                        AverageMolecularFormula.Write(sDef);                                                                                // MakerGen.cs:215
                        RepeatUnitAmountType.Write(sDef);                                                                                   // MakerGen.cs:215
                        RepeatUnit.Write(sDef);                                                                                             // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Repeat_Elements Elements                                                                                        // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Repeat_Elements();                                                                     // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Repeat_Elements elements;                                                                                              // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Repeat()                                                                                                        // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstancePolymer.repeat",                                                                                   // MakerGen.cs:423
                        ElementId = "SubstancePolymer.repeat"                                                                               // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. SubstancePolymer.class
            public ElementDefinitionInfo Class;                                                                                             // MakerGen.cs:211
            // 2. SubstancePolymer.geometry
            public ElementDefinitionInfo Geometry;                                                                                          // MakerGen.cs:211
            // 3. SubstancePolymer.copolymerConnectivity
            public ElementDefinitionInfo CopolymerConnectivity;                                                                             // MakerGen.cs:211
            // 4. SubstancePolymer.modification
            public ElementDefinitionInfo Modification;                                                                                      // MakerGen.cs:211
            // 5. SubstancePolymer.monomerSet
            public ElementDefinitionInfo MonomerSet;                                                                                        // MakerGen.cs:211
            // 12. SubstancePolymer.repeat
            public ElementDefinitionInfo Repeat;                                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public SubstancePolymer_Elements()                                                                                              // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. SubstancePolymer.class
                    this.Class = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Class",                                                                                                     // MakerGen.cs:230
                        Path= "SubstancePolymer.class",                                                                                     // MakerGen.cs:231
                        Id = "SubstancePolymer.class",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. SubstancePolymer.geometry
                    this.Geometry = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Geometry",                                                                                                  // MakerGen.cs:230
                        Path= "SubstancePolymer.geometry",                                                                                  // MakerGen.cs:231
                        Id = "SubstancePolymer.geometry",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. SubstancePolymer.copolymerConnectivity
                    this.CopolymerConnectivity = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "CopolymerConnectivity",                                                                                     // MakerGen.cs:230
                        Path= "SubstancePolymer.copolymerConnectivity",                                                                     // MakerGen.cs:231
                        Id = "SubstancePolymer.copolymerConnectivity",                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. SubstancePolymer.modification
                    this.Modification = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Modification",                                                                                              // MakerGen.cs:230
                        Path= "SubstancePolymer.modification",                                                                              // MakerGen.cs:231
                        Id = "SubstancePolymer.modification",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. SubstancePolymer.monomerSet
                    this.MonomerSet = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "MonomerSet",                                                                                                // MakerGen.cs:230
                        Path= "SubstancePolymer.monomerSet",                                                                                // MakerGen.cs:231
                        Id = "SubstancePolymer.monomerSet",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_MonomerSet                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. SubstancePolymer.repeat
                    this.Repeat = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Repeat",                                                                                                    // MakerGen.cs:230
                        Path= "SubstancePolymer.repeat",                                                                                    // MakerGen.cs:231
                        Id = "SubstancePolymer.repeat",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Repeat                                                                                                 // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Class.Write(sDef);                                                                                                          // MakerGen.cs:215
                Geometry.Write(sDef);                                                                                                       // MakerGen.cs:215
                CopolymerConnectivity.Write(sDef);                                                                                          // MakerGen.cs:215
                Modification.Write(sDef);                                                                                                   // MakerGen.cs:215
                MonomerSet.Write(sDef);                                                                                                     // MakerGen.cs:215
                Repeat.Write(sDef);                                                                                                         // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public SubstancePolymer_Elements Elements                                                                                           // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new SubstancePolymer_Elements();                                                                        // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        SubstancePolymer_Elements elements;                                                                                                 // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public SubstancePolymer()                                                                                                           // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "SubstancePolymer";                                                                                                 // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstancePolymer";                                                          // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "SubstancePolymer",                                                                                                  // MakerGen.cs:423
                ElementId = "SubstancePolymer"                                                                                              // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
