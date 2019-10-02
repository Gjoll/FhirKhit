using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public class Resource_SubstancePolymer : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                         // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 5. SubstancePolymer.monomerSet
        public class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 8. SubstancePolymer.monomerSet.startingMaterial.material
                public ElementDefinitionInfo Element_Material;                                                                              // MakerGen.cs:219
                // 9. SubstancePolymer.monomerSet.startingMaterial.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:219
                // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                public ElementDefinitionInfo Element_IsDefining;                                                                            // MakerGen.cs:219
                // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                public ElementDefinitionInfo Element_Amount;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "SubstancePolymer.monomerSet.startingMaterial",                                                              // MakerGen.cs:395
                        ElementId = "SubstancePolymer.monomerSet.startingMaterial"                                                          // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Material.Write(sDef);                                                                                           // MakerGen.cs:223
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_IsDefining.Write(sDef);                                                                                         // MakerGen.cs:223
                    Element_Amount.Write(sDef);                                                                                             // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_StartingMaterial()                                                                                              // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 8. SubstancePolymer.monomerSet.startingMaterial.material
                        this.Element_Material = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Material",                                                                                      // MakerGen.cs:238
                            Path= "SubstancePolymer.monomerSet.startingMaterial.material",                                                  // MakerGen.cs:239
                            Id = "SubstancePolymer.monomerSet.startingMaterial.material",                                                   // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 9. SubstancePolymer.monomerSet.startingMaterial.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Type",                                                                                          // MakerGen.cs:238
                            Path= "SubstancePolymer.monomerSet.startingMaterial.type",                                                      // MakerGen.cs:239
                            Id = "SubstancePolymer.monomerSet.startingMaterial.type",                                                       // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                        this.Element_IsDefining = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_IsDefining",                                                                                    // MakerGen.cs:238
                            Path= "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                                // MakerGen.cs:239
                            Id = "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                                 // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                        this.Element_Amount = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:238
                            Path= "SubstancePolymer.monomerSet.startingMaterial.amount",                                                    // MakerGen.cs:239
                            Id = "SubstancePolymer.monomerSet.startingMaterial.amount",                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                      // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 6. SubstancePolymer.monomerSet.ratioType
            public ElementDefinitionInfo Element_RatioType;                                                                                 // MakerGen.cs:219
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public ElementDefinitionInfo Element_StartingMaterial;                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SubstancePolymer.monomerSet",                                                                                   // MakerGen.cs:395
                    ElementId = "SubstancePolymer.monomerSet"                                                                               // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_RatioType.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_StartingMaterial.Write(sDef);                                                                                       // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_MonomerSet()                                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 6. SubstancePolymer.monomerSet.ratioType
                    this.Element_RatioType = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_RatioType",                                                                                         // MakerGen.cs:238
                        Path= "SubstancePolymer.monomerSet.ratioType",                                                                      // MakerGen.cs:239
                        Id = "SubstancePolymer.monomerSet.ratioType",                                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    this.Element_StartingMaterial = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_StartingMaterial",                                                                                  // MakerGen.cs:238
                        Path= "SubstancePolymer.monomerSet.startingMaterial",                                                               // MakerGen.cs:239
                        Id = "SubstancePolymer.monomerSet.startingMaterial",                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_StartingMaterial                                                                                       // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 12. SubstancePolymer.repeat
        public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 16. SubstancePolymer.repeat.repeatUnit
            public class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase                                        // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                    public ElementDefinitionInfo Element_Degree;                                                                            // MakerGen.cs:219
                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                    public ElementDefinitionInfo Element_Amount;                                                                            // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:394
                            Path = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                             // MakerGen.cs:395
                            ElementId = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation"                                         // MakerGen.cs:396
                        });                                                                                                                 // MakerGen.cs:397
                        Element_Degree.Write(sDef);                                                                                         // MakerGen.cs:223
                        Element_Amount.Write(sDef);                                                                                         // MakerGen.cs:223
                    }                                                                                                                       // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                    public Type_DegreeOfPolymerisation()                                                                                    // MakerGen.cs:402
                    {                                                                                                                       // MakerGen.cs:403
                        {                                                                                                                   // MakerGen.cs:234
                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                            this.Element_Degree = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Degree",                                                                                    // MakerGen.cs:238
                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                                   // MakerGen.cs:239
                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                                    // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:318
                                    {                                                                                                       // MakerGen.cs:319
                                    }                                                                                                       // MakerGen.cs:322
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                            this.Element_Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Amount",                                                                                    // MakerGen.cs:238
                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                                   // MakerGen.cs:239
                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                                    // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                  // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:407
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase                                      // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:219
                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                    public ElementDefinitionInfo Element_Representation;                                                                    // MakerGen.cs:219
                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                    public ElementDefinitionInfo Element_Attachment;                                                                        // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:394
                            Path = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                           // MakerGen.cs:395
                            ElementId = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation"                                       // MakerGen.cs:396
                        });                                                                                                                 // MakerGen.cs:397
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:223
                        Element_Representation.Write(sDef);                                                                                 // MakerGen.cs:223
                        Element_Attachment.Write(sDef);                                                                                     // MakerGen.cs:223
                    }                                                                                                                       // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                    public Type_StructuralRepresentation()                                                                                  // MakerGen.cs:402
                    {                                                                                                                       // MakerGen.cs:403
                        {                                                                                                                   // MakerGen.cs:234
                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Type",                                                                                      // MakerGen.cs:238
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                                   // MakerGen.cs:239
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                                    // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:318
                                    {                                                                                                       // MakerGen.cs:319
                                    }                                                                                                       // MakerGen.cs:322
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                            this.Element_Representation = new ElementDefinitionInfo                                                         // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Representation",                                                                            // MakerGen.cs:238
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",                         // MakerGen.cs:239
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",                          // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:303
                                    {                                                                                                       // MakerGen.cs:304
                                    }                                                                                                       // MakerGen.cs:307
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                            this.Element_Attachment = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Attachment",                                                                                // MakerGen.cs:238
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",                             // MakerGen.cs:239
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",                              // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_Attachment                                                       // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:407
                // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                public ElementDefinitionInfo Element_OrientationOfPolymerisation;                                                           // MakerGen.cs:219
                // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                public ElementDefinitionInfo Element_RepeatUnit;                                                                            // MakerGen.cs:219
                // 19. SubstancePolymer.repeat.repeatUnit.amount
                public ElementDefinitionInfo Element_Amount;                                                                                // MakerGen.cs:219
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public ElementDefinitionInfo Element_DegreeOfPolymerisation;                                                                // MakerGen.cs:219
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public ElementDefinitionInfo Element_StructuralRepresentation;                                                              // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "SubstancePolymer.repeat.repeatUnit",                                                                        // MakerGen.cs:395
                        ElementId = "SubstancePolymer.repeat.repeatUnit"                                                                    // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_OrientationOfPolymerisation.Write(sDef);                                                                        // MakerGen.cs:223
                    Element_RepeatUnit.Write(sDef);                                                                                         // MakerGen.cs:223
                    Element_Amount.Write(sDef);                                                                                             // MakerGen.cs:223
                    Element_DegreeOfPolymerisation.Write(sDef);                                                                             // MakerGen.cs:223
                    Element_StructuralRepresentation.Write(sDef);                                                                           // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_RepeatUnit()                                                                                                    // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                        this.Element_OrientationOfPolymerisation = new ElementDefinitionInfo                                                // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_OrientationOfPolymerisation",                                                                   // MakerGen.cs:238
                            Path= "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                                         // MakerGen.cs:239
                            Id = "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                                          // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                        this.Element_RepeatUnit = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_RepeatUnit",                                                                                    // MakerGen.cs:238
                            Path= "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                                          // MakerGen.cs:239
                            Id = "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                                           // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 19. SubstancePolymer.repeat.repeatUnit.amount
                        this.Element_Amount = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:238
                            Path= "SubstancePolymer.repeat.repeatUnit.amount",                                                              // MakerGen.cs:239
                            Id = "SubstancePolymer.repeat.repeatUnit.amount",                                                               // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                      // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                        this.Element_DegreeOfPolymerisation = new ElementDefinitionInfo                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_DegreeOfPolymerisation",                                                                        // MakerGen.cs:238
                            Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                              // MakerGen.cs:239
                            Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                               // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new Type_DegreeOfPolymerisation                                                                             // MakerGen.cs:262
                                {                                                                                                           // MakerGen.cs:263
                                }                                                                                                           // MakerGen.cs:264
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                        this.Element_StructuralRepresentation = new ElementDefinitionInfo                                                   // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_StructuralRepresentation",                                                                      // MakerGen.cs:238
                            Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                            // MakerGen.cs:239
                            Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                             // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new Type_StructuralRepresentation                                                                           // MakerGen.cs:262
                                {                                                                                                           // MakerGen.cs:263
                                }                                                                                                           // MakerGen.cs:264
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 13. SubstancePolymer.repeat.numberOfUnits
            public ElementDefinitionInfo Element_NumberOfUnits;                                                                             // MakerGen.cs:219
            // 14. SubstancePolymer.repeat.averageMolecularFormula
            public ElementDefinitionInfo Element_AverageMolecularFormula;                                                                   // MakerGen.cs:219
            // 15. SubstancePolymer.repeat.repeatUnitAmountType
            public ElementDefinitionInfo Element_RepeatUnitAmountType;                                                                      // MakerGen.cs:219
            // 16. SubstancePolymer.repeat.repeatUnit
            public ElementDefinitionInfo Element_RepeatUnit;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SubstancePolymer.repeat",                                                                                       // MakerGen.cs:395
                    ElementId = "SubstancePolymer.repeat"                                                                                   // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_NumberOfUnits.Write(sDef);                                                                                          // MakerGen.cs:223
                Element_AverageMolecularFormula.Write(sDef);                                                                                // MakerGen.cs:223
                Element_RepeatUnitAmountType.Write(sDef);                                                                                   // MakerGen.cs:223
                Element_RepeatUnit.Write(sDef);                                                                                             // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Repeat()                                                                                                            // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    this.Element_NumberOfUnits = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_NumberOfUnits",                                                                                     // MakerGen.cs:238
                        Path= "SubstancePolymer.repeat.numberOfUnits",                                                                      // MakerGen.cs:239
                        Id = "SubstancePolymer.repeat.numberOfUnits",                                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    this.Element_AverageMolecularFormula = new ElementDefinitionInfo                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_AverageMolecularFormula",                                                                           // MakerGen.cs:238
                        Path= "SubstancePolymer.repeat.averageMolecularFormula",                                                            // MakerGen.cs:239
                        Id = "SubstancePolymer.repeat.averageMolecularFormula",                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    this.Element_RepeatUnitAmountType = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_RepeatUnitAmountType",                                                                              // MakerGen.cs:238
                        Path= "SubstancePolymer.repeat.repeatUnitAmountType",                                                               // MakerGen.cs:239
                        Id = "SubstancePolymer.repeat.repeatUnitAmountType",                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. SubstancePolymer.repeat.repeatUnit
                    this.Element_RepeatUnit = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_RepeatUnit",                                                                                        // MakerGen.cs:238
                        Path= "SubstancePolymer.repeat.repeatUnit",                                                                         // MakerGen.cs:239
                        Id = "SubstancePolymer.repeat.repeatUnit",                                                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_RepeatUnit                                                                                             // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. SubstancePolymer.class
        public ElementDefinitionInfo Element_Class;                                                                                         // MakerGen.cs:219
        // 2. SubstancePolymer.geometry
        public ElementDefinitionInfo Element_Geometry;                                                                                      // MakerGen.cs:219
        // 3. SubstancePolymer.copolymerConnectivity
        public ElementDefinitionInfo Element_CopolymerConnectivity;                                                                         // MakerGen.cs:219
        // 4. SubstancePolymer.modification
        public ElementDefinitionInfo Element_Modification;                                                                                  // MakerGen.cs:219
        // 5. SubstancePolymer.monomerSet
        public ElementDefinitionInfo Element_MonomerSet;                                                                                    // MakerGen.cs:219
        // 12. SubstancePolymer.repeat
        public ElementDefinitionInfo Element_Repeat;                                                                                        // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "SubstancePolymer",                                                                                                  // MakerGen.cs:395
                ElementId = "SubstancePolymer"                                                                                              // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Class.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Geometry.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_CopolymerConnectivity.Write(sDef);                                                                                      // MakerGen.cs:223
            Element_Modification.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_MonomerSet.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Repeat.Write(sDef);                                                                                                     // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_SubstancePolymer()                                                                                                  // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. SubstancePolymer.class
                this.Element_Class = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Class",                                                                                                 // MakerGen.cs:238
                    Path= "SubstancePolymer.class",                                                                                         // MakerGen.cs:239
                    Id = "SubstancePolymer.class",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. SubstancePolymer.geometry
                this.Element_Geometry = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Geometry",                                                                                              // MakerGen.cs:238
                    Path= "SubstancePolymer.geometry",                                                                                      // MakerGen.cs:239
                    Id = "SubstancePolymer.geometry",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. SubstancePolymer.copolymerConnectivity
                this.Element_CopolymerConnectivity = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_CopolymerConnectivity",                                                                                 // MakerGen.cs:238
                    Path= "SubstancePolymer.copolymerConnectivity",                                                                         // MakerGen.cs:239
                    Id = "SubstancePolymer.copolymerConnectivity",                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. SubstancePolymer.modification
                this.Element_Modification = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Modification",                                                                                          // MakerGen.cs:238
                    Path= "SubstancePolymer.modification",                                                                                  // MakerGen.cs:239
                    Id = "SubstancePolymer.modification",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. SubstancePolymer.monomerSet
                this.Element_MonomerSet = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MonomerSet",                                                                                            // MakerGen.cs:238
                    Path= "SubstancePolymer.monomerSet",                                                                                    // MakerGen.cs:239
                    Id = "SubstancePolymer.monomerSet",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_MonomerSet                                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. SubstancePolymer.repeat
                this.Element_Repeat = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Repeat",                                                                                                // MakerGen.cs:238
                    Path= "SubstancePolymer.repeat",                                                                                        // MakerGen.cs:239
                    Id = "SubstancePolymer.repeat",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Repeat                                                                                                     // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "SubstancePolymer";                                                                                                 // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstancePolymer";                                                          // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
