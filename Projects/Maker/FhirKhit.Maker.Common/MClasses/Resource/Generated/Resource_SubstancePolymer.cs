using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public class Resource_SubstancePolymer : FhirKhit.Maker.Common.Resource.ResourceBase                                                    // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_SubstancePolymer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 5. SubstancePolymer.monomerSet
            public class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_MonomerSet_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    public class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_StartingMaterial_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                           // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 8. SubstancePolymer.monomerSet.startingMaterial.material
                            public ElementDefinitionInfo Element_Material;                                                                  // MakerGen.cs:211
                            // 9. SubstancePolymer.monomerSet.startingMaterial.type
                            public ElementDefinitionInfo Element_Type;                                                                      // MakerGen.cs:211
                            // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                            public ElementDefinitionInfo Element_IsDefining;                                                                // MakerGen.cs:211
                            // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                            public ElementDefinitionInfo Element_Amount;                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_StartingMaterial_Elements()                                                                         // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 8. SubstancePolymer.monomerSet.startingMaterial.material
                                    this.Element_Material = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Material",                                                                          // MakerGen.cs:230
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.material",                                      // MakerGen.cs:231
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.material",                                       // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 9. SubstancePolymer.monomerSet.startingMaterial.type
                                    this.Element_Type = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Type",                                                                              // MakerGen.cs:230
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.type",                                          // MakerGen.cs:231
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.type",                                           // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                                    this.Element_IsDefining = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_IsDefining",                                                                        // MakerGen.cs:230
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
                                    this.Element_Amount = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Amount",                                                                            // MakerGen.cs:230
                                        Path= "SubstancePolymer.monomerSet.startingMaterial.amount",                                        // MakerGen.cs:231
                                        Id = "SubstancePolymer.monomerSet.startingMaterial.amount",                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                          // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_Material.Write(sDef);                                                                               // MakerGen.cs:215
                                Element_Type.Write(sDef);                                                                                   // MakerGen.cs:215
                                Element_IsDefining.Write(sDef);                                                                             // MakerGen.cs:215
                                Element_Amount.Write(sDef);                                                                                 // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_StartingMaterial_Elements Elements                                                                      // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_StartingMaterial_Elements();                                                   // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_StartingMaterial_Elements elements;                                                                            // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_StartingMaterial()                                                                                      // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "SubstancePolymer.monomerSet.startingMaterial",                                                      // MakerGen.cs:420
                                ElementId = "SubstancePolymer.monomerSet.startingMaterial"                                                  // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 6. SubstancePolymer.monomerSet.ratioType
                    public ElementDefinitionInfo Element_RatioType;                                                                         // MakerGen.cs:211
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    public ElementDefinitionInfo Element_StartingMaterial;                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_MonomerSet_Elements()                                                                                       // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 6. SubstancePolymer.monomerSet.ratioType
                            this.Element_RatioType = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_RatioType",                                                                                 // MakerGen.cs:230
                                Path= "SubstancePolymer.monomerSet.ratioType",                                                              // MakerGen.cs:231
                                Id = "SubstancePolymer.monomerSet.ratioType",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. SubstancePolymer.monomerSet.startingMaterial
                            this.Element_StartingMaterial = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_StartingMaterial",                                                                          // MakerGen.cs:230
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_RatioType.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_StartingMaterial.Write(sDef);                                                                               // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_MonomerSet_Elements Elements                                                                                    // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_MonomerSet_Elements();                                                                 // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_MonomerSet_Elements elements;                                                                                          // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_MonomerSet()                                                                                                    // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "SubstancePolymer.monomerSet",                                                                               // MakerGen.cs:420
                        ElementId = "SubstancePolymer.monomerSet"                                                                           // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 12. SubstancePolymer.repeat
            public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Repeat_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 16. SubstancePolymer.repeat.repeatUnit
                    public class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_RepeatUnit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                            public class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase                            // MakerGen.cs:376
                            {                                                                                                               // MakerGen.cs:377
                                public class Type_DegreeOfPolymerisation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase             // MakerGen.cs:378
                                {                                                                                                           // MakerGen.cs:379
                                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                                    public ElementDefinitionInfo Element_Degree;                                                            // MakerGen.cs:211
                                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                                    public ElementDefinitionInfo Element_Amount;                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                                    public Type_DegreeOfPolymerisation_Elements()                                                           // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:226
                                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                                            this.Element_Degree = new ElementDefinitionInfo                                                 // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Degree",                                                                    // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                   // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                  // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                                            this.Element_Amount = new ElementDefinitionInfo                                                 // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Amount",                                                                    // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                   // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                  // MakerGen.cs:350
                                                    {                                                                                       // MakerGen.cs:351
                                                    }                                                                                       // MakerGen.cs:352
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:390
                                    {                                                                                                       // MakerGen.cs:391
                                        base.Write(sDef);                                                                                   // MakerGen.cs:392
                                        Element_Degree.Write(sDef);                                                                         // MakerGen.cs:215
                                        Element_Amount.Write(sDef);                                                                         // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:394
                                }                                                                                                           // MakerGen.cs:396
                                public Type_DegreeOfPolymerisation_Elements Elements                                                        // MakerGen.cs:398
                                {                                                                                                           // MakerGen.cs:399
                                    get                                                                                                     // MakerGen.cs:400
                                    {                                                                                                       // MakerGen.cs:401
                                        if (this.elements == null)                                                                          // MakerGen.cs:402
                                            this.elements = new Type_DegreeOfPolymerisation_Elements();                                     // MakerGen.cs:403
                                        return this.elements;                                                                               // MakerGen.cs:404
                                    }                                                                                                       // MakerGen.cs:405
                                }                                                                                                           // MakerGen.cs:406
                                Type_DegreeOfPolymerisation_Elements elements;                                                              // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                                public Type_DegreeOfPolymerisation()                                                                        // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:411
                                }                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:416
                                {                                                                                                           // MakerGen.cs:417
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:418
                                    {                                                                                                       // MakerGen.cs:419
                                        Path = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                 // MakerGen.cs:420
                                        ElementId = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation"                             // MakerGen.cs:421
                                    });                                                                                                     // MakerGen.cs:422
                                    if (this.elements != null)                                                                              // MakerGen.cs:423
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:424
                                }                                                                                                           // MakerGen.cs:425
                            }                                                                                                               // MakerGen.cs:426
                            // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                            public class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase                          // MakerGen.cs:376
                            {                                                                                                               // MakerGen.cs:377
                                public class Type_StructuralRepresentation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase           // MakerGen.cs:378
                                {                                                                                                           // MakerGen.cs:379
                                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                                    public ElementDefinitionInfo Element_Type;                                                              // MakerGen.cs:211
                                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                                    public ElementDefinitionInfo Element_Representation;                                                    // MakerGen.cs:211
                                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                                    public ElementDefinitionInfo Element_Attachment;                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                                    public Type_StructuralRepresentation_Elements()                                                         // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:226
                                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                                            this.Element_Type = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Type",                                                                      // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                   // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                  // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                                            this.Element_Representation = new ElementDefinitionInfo                                         // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Representation",                                                            // MakerGen.cs:230
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
                                            this.Element_Attachment = new ElementDefinitionInfo                                             // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Attachment",                                                                // MakerGen.cs:230
                                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",             // MakerGen.cs:231
                                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",              // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_Attachment                                       // MakerGen.cs:350
                                                    {                                                                                       // MakerGen.cs:351
                                                    }                                                                                       // MakerGen.cs:352
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:390
                                    {                                                                                                       // MakerGen.cs:391
                                        base.Write(sDef);                                                                                   // MakerGen.cs:392
                                        Element_Type.Write(sDef);                                                                           // MakerGen.cs:215
                                        Element_Representation.Write(sDef);                                                                 // MakerGen.cs:215
                                        Element_Attachment.Write(sDef);                                                                     // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:394
                                }                                                                                                           // MakerGen.cs:396
                                public Type_StructuralRepresentation_Elements Elements                                                      // MakerGen.cs:398
                                {                                                                                                           // MakerGen.cs:399
                                    get                                                                                                     // MakerGen.cs:400
                                    {                                                                                                       // MakerGen.cs:401
                                        if (this.elements == null)                                                                          // MakerGen.cs:402
                                            this.elements = new Type_StructuralRepresentation_Elements();                                   // MakerGen.cs:403
                                        return this.elements;                                                                               // MakerGen.cs:404
                                    }                                                                                                       // MakerGen.cs:405
                                }                                                                                                           // MakerGen.cs:406
                                Type_StructuralRepresentation_Elements elements;                                                            // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                                public Type_StructuralRepresentation()                                                                      // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:411
                                }                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:416
                                {                                                                                                           // MakerGen.cs:417
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:418
                                    {                                                                                                       // MakerGen.cs:419
                                        Path = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                               // MakerGen.cs:420
                                        ElementId = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation"                           // MakerGen.cs:421
                                    });                                                                                                     // MakerGen.cs:422
                                    if (this.elements != null)                                                                              // MakerGen.cs:423
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:424
                                }                                                                                                           // MakerGen.cs:425
                            }                                                                                                               // MakerGen.cs:426
                            // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                            public ElementDefinitionInfo Element_OrientationOfPolymerisation;                                               // MakerGen.cs:211
                            // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                            public ElementDefinitionInfo Element_RepeatUnit;                                                                // MakerGen.cs:211
                            // 19. SubstancePolymer.repeat.repeatUnit.amount
                            public ElementDefinitionInfo Element_Amount;                                                                    // MakerGen.cs:211
                            // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                            public ElementDefinitionInfo Element_DegreeOfPolymerisation;                                                    // MakerGen.cs:211
                            // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                            public ElementDefinitionInfo Element_StructuralRepresentation;                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_RepeatUnit_Elements()                                                                               // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                                    this.Element_OrientationOfPolymerisation = new ElementDefinitionInfo                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_OrientationOfPolymerisation",                                                       // MakerGen.cs:230
                                        Path= "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                             // MakerGen.cs:231
                                        Id = "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                                    this.Element_RepeatUnit = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_RepeatUnit",                                                                        // MakerGen.cs:230
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
                                    this.Element_Amount = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Amount",                                                                            // MakerGen.cs:230
                                        Path= "SubstancePolymer.repeat.repeatUnit.amount",                                                  // MakerGen.cs:231
                                        Id = "SubstancePolymer.repeat.repeatUnit.amount",                                                   // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                          // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                                    this.Element_DegreeOfPolymerisation = new ElementDefinitionInfo                                         // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_DegreeOfPolymerisation",                                                            // MakerGen.cs:230
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
                                    this.Element_StructuralRepresentation = new ElementDefinitionInfo                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_StructuralRepresentation",                                                          // MakerGen.cs:230
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
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_OrientationOfPolymerisation.Write(sDef);                                                            // MakerGen.cs:215
                                Element_RepeatUnit.Write(sDef);                                                                             // MakerGen.cs:215
                                Element_Amount.Write(sDef);                                                                                 // MakerGen.cs:215
                                Element_DegreeOfPolymerisation.Write(sDef);                                                                 // MakerGen.cs:215
                                Element_StructuralRepresentation.Write(sDef);                                                               // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_RepeatUnit_Elements Elements                                                                            // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_RepeatUnit_Elements();                                                         // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_RepeatUnit_Elements elements;                                                                                  // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_RepeatUnit()                                                                                            // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "SubstancePolymer.repeat.repeatUnit",                                                                // MakerGen.cs:420
                                ElementId = "SubstancePolymer.repeat.repeatUnit"                                                            // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    public ElementDefinitionInfo Element_NumberOfUnits;                                                                     // MakerGen.cs:211
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    public ElementDefinitionInfo Element_AverageMolecularFormula;                                                           // MakerGen.cs:211
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    public ElementDefinitionInfo Element_RepeatUnitAmountType;                                                              // MakerGen.cs:211
                    // 16. SubstancePolymer.repeat.repeatUnit
                    public ElementDefinitionInfo Element_RepeatUnit;                                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Repeat_Elements()                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. SubstancePolymer.repeat.numberOfUnits
                            this.Element_NumberOfUnits = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_NumberOfUnits",                                                                             // MakerGen.cs:230
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
                            this.Element_AverageMolecularFormula = new ElementDefinitionInfo                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_AverageMolecularFormula",                                                                   // MakerGen.cs:230
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
                            this.Element_RepeatUnitAmountType = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_RepeatUnitAmountType",                                                                      // MakerGen.cs:230
                                Path= "SubstancePolymer.repeat.repeatUnitAmountType",                                                       // MakerGen.cs:231
                                Id = "SubstancePolymer.repeat.repeatUnitAmountType",                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. SubstancePolymer.repeat.repeatUnit
                            this.Element_RepeatUnit = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_RepeatUnit",                                                                                // MakerGen.cs:230
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_NumberOfUnits.Write(sDef);                                                                                  // MakerGen.cs:215
                        Element_AverageMolecularFormula.Write(sDef);                                                                        // MakerGen.cs:215
                        Element_RepeatUnitAmountType.Write(sDef);                                                                           // MakerGen.cs:215
                        Element_RepeatUnit.Write(sDef);                                                                                     // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Repeat_Elements Elements                                                                                        // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Repeat_Elements();                                                                     // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Repeat_Elements elements;                                                                                              // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Repeat()                                                                                                        // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "SubstancePolymer.repeat",                                                                                   // MakerGen.cs:420
                        ElementId = "SubstancePolymer.repeat"                                                                               // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. SubstancePolymer.class
            public ElementDefinitionInfo Element_Class;                                                                                     // MakerGen.cs:211
            // 2. SubstancePolymer.geometry
            public ElementDefinitionInfo Element_Geometry;                                                                                  // MakerGen.cs:211
            // 3. SubstancePolymer.copolymerConnectivity
            public ElementDefinitionInfo Element_CopolymerConnectivity;                                                                     // MakerGen.cs:211
            // 4. SubstancePolymer.modification
            public ElementDefinitionInfo Element_Modification;                                                                              // MakerGen.cs:211
            // 5. SubstancePolymer.monomerSet
            public ElementDefinitionInfo Element_MonomerSet;                                                                                // MakerGen.cs:211
            // 12. SubstancePolymer.repeat
            public ElementDefinitionInfo Element_Repeat;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_SubstancePolymer_Elements()                                                                                     // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. SubstancePolymer.class
                    this.Element_Class = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Class",                                                                                             // MakerGen.cs:230
                        Path= "SubstancePolymer.class",                                                                                     // MakerGen.cs:231
                        Id = "SubstancePolymer.class",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. SubstancePolymer.geometry
                    this.Element_Geometry = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Geometry",                                                                                          // MakerGen.cs:230
                        Path= "SubstancePolymer.geometry",                                                                                  // MakerGen.cs:231
                        Id = "SubstancePolymer.geometry",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. SubstancePolymer.copolymerConnectivity
                    this.Element_CopolymerConnectivity = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_CopolymerConnectivity",                                                                             // MakerGen.cs:230
                        Path= "SubstancePolymer.copolymerConnectivity",                                                                     // MakerGen.cs:231
                        Id = "SubstancePolymer.copolymerConnectivity",                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. SubstancePolymer.modification
                    this.Element_Modification = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Modification",                                                                                      // MakerGen.cs:230
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
                    this.Element_MonomerSet = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_MonomerSet",                                                                                        // MakerGen.cs:230
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
                    this.Element_Repeat = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Repeat",                                                                                            // MakerGen.cs:230
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
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Class.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Geometry.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_CopolymerConnectivity.Write(sDef);                                                                                  // MakerGen.cs:215
                Element_Modification.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_MonomerSet.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Repeat.Write(sDef);                                                                                                 // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_SubstancePolymer_Elements Elements                                                                                  // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_SubstancePolymer_Elements();                                                               // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_SubstancePolymer_Elements elements;                                                                                        // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_SubstancePolymer()                                                                                                  // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "SubstancePolymer";                                                                                                 // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstancePolymer";                                                          // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "SubstancePolymer",                                                                                                  // MakerGen.cs:420
                ElementId = "SubstancePolymer"                                                                                              // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
