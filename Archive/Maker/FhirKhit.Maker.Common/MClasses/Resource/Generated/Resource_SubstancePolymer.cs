using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'SubstancePolymer'
    /// </summary>
    // 0. SubstancePolymer
    public partial class Resource_SubstancePolymer : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                 // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 5. SubstancePolymer.monomerSet
        public partial class Type_MonomerSet : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public partial class Type_StartingMaterial : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 8. SubstancePolymer.monomerSet.startingMaterial.material
                public ElementDefinitionInfo Element_Material;                                                                              // MakerGen.cs:217
                // 9. SubstancePolymer.monomerSet.startingMaterial.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:217
                // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                public ElementDefinitionInfo Element_IsDefining;                                                                            // MakerGen.cs:217
                // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                public ElementDefinitionInfo Element_Amount;                                                                                // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "SubstancePolymer.monomerSet.startingMaterial",                                                              // MakerGen.cs:393
                        ElementId = "SubstancePolymer.monomerSet.startingMaterial"                                                          // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Material.Write(sDef);                                                                                           // MakerGen.cs:221
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_IsDefining.Write(sDef);                                                                                         // MakerGen.cs:221
                    Element_Amount.Write(sDef);                                                                                             // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_StartingMaterial()                                                                                              // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 8. SubstancePolymer.monomerSet.startingMaterial.material
                        this.Element_Material = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Material",                                                                                      // MakerGen.cs:236
                            Path= "SubstancePolymer.monomerSet.startingMaterial.material",                                                  // MakerGen.cs:237
                            Id = "SubstancePolymer.monomerSet.startingMaterial.material",                                                   // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 9. SubstancePolymer.monomerSet.startingMaterial.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Type",                                                                                          // MakerGen.cs:236
                            Path= "SubstancePolymer.monomerSet.startingMaterial.type",                                                      // MakerGen.cs:237
                            Id = "SubstancePolymer.monomerSet.startingMaterial.type",                                                       // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 10. SubstancePolymer.monomerSet.startingMaterial.isDefining
                        this.Element_IsDefining = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_IsDefining",                                                                                    // MakerGen.cs:236
                            Path= "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                                // MakerGen.cs:237
                            Id = "SubstancePolymer.monomerSet.startingMaterial.isDefining",                                                 // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 11. SubstancePolymer.monomerSet.startingMaterial.amount
                        this.Element_Amount = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:236
                            Path= "SubstancePolymer.monomerSet.startingMaterial.amount",                                                    // MakerGen.cs:237
                            Id = "SubstancePolymer.monomerSet.startingMaterial.amount",                                                     // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                      // MakerGen.cs:356
                                {                                                                                                           // MakerGen.cs:357
                                }                                                                                                           // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 6. SubstancePolymer.monomerSet.ratioType
            public ElementDefinitionInfo Element_RatioType;                                                                                 // MakerGen.cs:217
            // 7. SubstancePolymer.monomerSet.startingMaterial
            public ElementDefinitionInfo Element_StartingMaterial;                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "SubstancePolymer.monomerSet",                                                                                   // MakerGen.cs:393
                    ElementId = "SubstancePolymer.monomerSet"                                                                               // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_RatioType.Write(sDef);                                                                                              // MakerGen.cs:221
                Element_StartingMaterial.Write(sDef);                                                                                       // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_MonomerSet()                                                                                                        // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 6. SubstancePolymer.monomerSet.ratioType
                    this.Element_RatioType = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_RatioType",                                                                                         // MakerGen.cs:236
                        Path= "SubstancePolymer.monomerSet.ratioType",                                                                      // MakerGen.cs:237
                        Id = "SubstancePolymer.monomerSet.ratioType",                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 7. SubstancePolymer.monomerSet.startingMaterial
                    this.Element_StartingMaterial = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_StartingMaterial",                                                                                  // MakerGen.cs:236
                        Path= "SubstancePolymer.monomerSet.startingMaterial",                                                               // MakerGen.cs:237
                        Id = "SubstancePolymer.monomerSet.startingMaterial",                                                                // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_StartingMaterial                                                                                       // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 12. SubstancePolymer.repeat
        public partial class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 16. SubstancePolymer.repeat.repeatUnit
            public partial class Type_RepeatUnit : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public partial class Type_DegreeOfPolymerisation : FhirKhit.Maker.Common.Complex.ComplexBase                                // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                    public ElementDefinitionInfo Element_Degree;                                                                            // MakerGen.cs:217
                    // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                    public ElementDefinitionInfo Element_Amount;                                                                            // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                             // MakerGen.cs:393
                            ElementId = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation"                                         // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Degree.Write(sDef);                                                                                         // MakerGen.cs:221
                        Element_Amount.Write(sDef);                                                                                         // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_DegreeOfPolymerisation()                                                                                    // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 21. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree
                            this.Element_Degree = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Degree",                                                                                    // MakerGen.cs:236
                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                                   // MakerGen.cs:237
                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.degree",                                    // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:316
                                    {                                                                                                       // MakerGen.cs:317
                                    }                                                                                                       // MakerGen.cs:320
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 22. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount
                            this.Element_Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Amount",                                                                                    // MakerGen.cs:236
                                Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                                   // MakerGen.cs:237
                                Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation.amount",                                    // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                  // MakerGen.cs:356
                                    {                                                                                                       // MakerGen.cs:357
                                    }                                                                                                       // MakerGen.cs:358
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public partial class Type_StructuralRepresentation : FhirKhit.Maker.Common.Complex.ComplexBase                              // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:217
                    // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                    public ElementDefinitionInfo Element_Representation;                                                                    // MakerGen.cs:217
                    // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                    public ElementDefinitionInfo Element_Attachment;                                                                        // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                           // MakerGen.cs:393
                            ElementId = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation"                                       // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:221
                        Element_Representation.Write(sDef);                                                                                 // MakerGen.cs:221
                        Element_Attachment.Write(sDef);                                                                                     // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_StructuralRepresentation()                                                                                  // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 24. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Type",                                                                                      // MakerGen.cs:236
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                                   // MakerGen.cs:237
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.type",                                    // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:316
                                    {                                                                                                       // MakerGen.cs:317
                                    }                                                                                                       // MakerGen.cs:320
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 25. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation
                            this.Element_Representation = new ElementDefinitionInfo                                                         // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Representation",                                                                            // MakerGen.cs:236
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",                         // MakerGen.cs:237
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.representation",                          // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 26. SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment
                            this.Element_Attachment = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Attachment",                                                                                // MakerGen.cs:236
                                Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",                             // MakerGen.cs:237
                                Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation.attachment",                              // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Complex.Type_Attachment                                                       // MakerGen.cs:356
                                    {                                                                                                       // MakerGen.cs:357
                                    }                                                                                                       // MakerGen.cs:358
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                public ElementDefinitionInfo Element_OrientationOfPolymerisation;                                                           // MakerGen.cs:217
                // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                public ElementDefinitionInfo Element_RepeatUnit;                                                                            // MakerGen.cs:217
                // 19. SubstancePolymer.repeat.repeatUnit.amount
                public ElementDefinitionInfo Element_Amount;                                                                                // MakerGen.cs:217
                // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                public ElementDefinitionInfo Element_DegreeOfPolymerisation;                                                                // MakerGen.cs:217
                // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                public ElementDefinitionInfo Element_StructuralRepresentation;                                                              // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "SubstancePolymer.repeat.repeatUnit",                                                                        // MakerGen.cs:393
                        ElementId = "SubstancePolymer.repeat.repeatUnit"                                                                    // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_OrientationOfPolymerisation.Write(sDef);                                                                        // MakerGen.cs:221
                    Element_RepeatUnit.Write(sDef);                                                                                         // MakerGen.cs:221
                    Element_Amount.Write(sDef);                                                                                             // MakerGen.cs:221
                    Element_DegreeOfPolymerisation.Write(sDef);                                                                             // MakerGen.cs:221
                    Element_StructuralRepresentation.Write(sDef);                                                                           // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_RepeatUnit()                                                                                                    // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 17. SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation
                        this.Element_OrientationOfPolymerisation = new ElementDefinitionInfo                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_OrientationOfPolymerisation",                                                                   // MakerGen.cs:236
                            Path= "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                                         // MakerGen.cs:237
                            Id = "SubstancePolymer.repeat.repeatUnit.orientationOfPolymerisation",                                          // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 18. SubstancePolymer.repeat.repeatUnit.repeatUnit
                        this.Element_RepeatUnit = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_RepeatUnit",                                                                                    // MakerGen.cs:236
                            Path= "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                                          // MakerGen.cs:237
                            Id = "SubstancePolymer.repeat.repeatUnit.repeatUnit",                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 19. SubstancePolymer.repeat.repeatUnit.amount
                        this.Element_Amount = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:236
                            Path= "SubstancePolymer.repeat.repeatUnit.amount",                                                              // MakerGen.cs:237
                            Id = "SubstancePolymer.repeat.repeatUnit.amount",                                                               // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_SubstanceAmount                                                      // MakerGen.cs:356
                                {                                                                                                           // MakerGen.cs:357
                                }                                                                                                           // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 20. SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation
                        this.Element_DegreeOfPolymerisation = new ElementDefinitionInfo                                                     // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_DegreeOfPolymerisation",                                                                        // MakerGen.cs:236
                            Path= "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                              // MakerGen.cs:237
                            Id = "SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation",                                               // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_DegreeOfPolymerisation                                                                             // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 23. SubstancePolymer.repeat.repeatUnit.structuralRepresentation
                        this.Element_StructuralRepresentation = new ElementDefinitionInfo                                                   // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_StructuralRepresentation",                                                                      // MakerGen.cs:236
                            Path= "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                            // MakerGen.cs:237
                            Id = "SubstancePolymer.repeat.repeatUnit.structuralRepresentation",                                             // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_StructuralRepresentation                                                                           // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 13. SubstancePolymer.repeat.numberOfUnits
            public ElementDefinitionInfo Element_NumberOfUnits;                                                                             // MakerGen.cs:217
            // 14. SubstancePolymer.repeat.averageMolecularFormula
            public ElementDefinitionInfo Element_AverageMolecularFormula;                                                                   // MakerGen.cs:217
            // 15. SubstancePolymer.repeat.repeatUnitAmountType
            public ElementDefinitionInfo Element_RepeatUnitAmountType;                                                                      // MakerGen.cs:217
            // 16. SubstancePolymer.repeat.repeatUnit
            public ElementDefinitionInfo Element_RepeatUnit;                                                                                // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "SubstancePolymer.repeat",                                                                                       // MakerGen.cs:393
                    ElementId = "SubstancePolymer.repeat"                                                                                   // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_NumberOfUnits.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_AverageMolecularFormula.Write(sDef);                                                                                // MakerGen.cs:221
                Element_RepeatUnitAmountType.Write(sDef);                                                                                   // MakerGen.cs:221
                Element_RepeatUnit.Write(sDef);                                                                                             // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Repeat()                                                                                                            // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 13. SubstancePolymer.repeat.numberOfUnits
                    this.Element_NumberOfUnits = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_NumberOfUnits",                                                                                     // MakerGen.cs:236
                        Path= "SubstancePolymer.repeat.numberOfUnits",                                                                      // MakerGen.cs:237
                        Id = "SubstancePolymer.repeat.numberOfUnits",                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 14. SubstancePolymer.repeat.averageMolecularFormula
                    this.Element_AverageMolecularFormula = new ElementDefinitionInfo                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_AverageMolecularFormula",                                                                           // MakerGen.cs:236
                        Path= "SubstancePolymer.repeat.averageMolecularFormula",                                                            // MakerGen.cs:237
                        Id = "SubstancePolymer.repeat.averageMolecularFormula",                                                             // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 15. SubstancePolymer.repeat.repeatUnitAmountType
                    this.Element_RepeatUnitAmountType = new ElementDefinitionInfo                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_RepeatUnitAmountType",                                                                              // MakerGen.cs:236
                        Path= "SubstancePolymer.repeat.repeatUnitAmountType",                                                               // MakerGen.cs:237
                        Id = "SubstancePolymer.repeat.repeatUnitAmountType",                                                                // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 16. SubstancePolymer.repeat.repeatUnit
                    this.Element_RepeatUnit = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_RepeatUnit",                                                                                        // MakerGen.cs:236
                        Path= "SubstancePolymer.repeat.repeatUnit",                                                                         // MakerGen.cs:237
                        Id = "SubstancePolymer.repeat.repeatUnit",                                                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_RepeatUnit                                                                                             // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. SubstancePolymer.class
        public ElementDefinitionInfo Element_Class;                                                                                         // MakerGen.cs:217
        // 2. SubstancePolymer.geometry
        public ElementDefinitionInfo Element_Geometry;                                                                                      // MakerGen.cs:217
        // 3. SubstancePolymer.copolymerConnectivity
        public ElementDefinitionInfo Element_CopolymerConnectivity;                                                                         // MakerGen.cs:217
        // 4. SubstancePolymer.modification
        public ElementDefinitionInfo Element_Modification;                                                                                  // MakerGen.cs:217
        // 5. SubstancePolymer.monomerSet
        public ElementDefinitionInfo Element_MonomerSet;                                                                                    // MakerGen.cs:217
        // 12. SubstancePolymer.repeat
        public ElementDefinitionInfo Element_Repeat;                                                                                        // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "SubstancePolymer",                                                                                                  // MakerGen.cs:393
                ElementId = "SubstancePolymer"                                                                                              // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Class.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Geometry.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_CopolymerConnectivity.Write(sDef);                                                                                      // MakerGen.cs:221
            Element_Modification.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_MonomerSet.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Repeat.Write(sDef);                                                                                                     // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_SubstancePolymer()                                                                                                  // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. SubstancePolymer.class
                this.Element_Class = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Class",                                                                                                 // MakerGen.cs:236
                    Path= "SubstancePolymer.class",                                                                                         // MakerGen.cs:237
                    Id = "SubstancePolymer.class",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. SubstancePolymer.geometry
                this.Element_Geometry = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Geometry",                                                                                              // MakerGen.cs:236
                    Path= "SubstancePolymer.geometry",                                                                                      // MakerGen.cs:237
                    Id = "SubstancePolymer.geometry",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. SubstancePolymer.copolymerConnectivity
                this.Element_CopolymerConnectivity = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_CopolymerConnectivity",                                                                                 // MakerGen.cs:236
                    Path= "SubstancePolymer.copolymerConnectivity",                                                                         // MakerGen.cs:237
                    Id = "SubstancePolymer.copolymerConnectivity",                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. SubstancePolymer.modification
                this.Element_Modification = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Modification",                                                                                          // MakerGen.cs:236
                    Path= "SubstancePolymer.modification",                                                                                  // MakerGen.cs:237
                    Id = "SubstancePolymer.modification",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. SubstancePolymer.monomerSet
                this.Element_MonomerSet = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_MonomerSet",                                                                                            // MakerGen.cs:236
                    Path= "SubstancePolymer.monomerSet",                                                                                    // MakerGen.cs:237
                    Id = "SubstancePolymer.monomerSet",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_MonomerSet                                                                                                 // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. SubstancePolymer.repeat
                this.Element_Repeat = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Repeat",                                                                                                // MakerGen.cs:236
                    Path= "SubstancePolymer.repeat",                                                                                        // MakerGen.cs:237
                    Id = "SubstancePolymer.repeat",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Repeat                                                                                                     // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "SubstancePolymer";                                                                                                 // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstancePolymer";                                                          // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
